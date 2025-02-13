using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Player instance
    public static Player Instance { get; private set; }

    //body of the player
    private Rigidbody rigid_body;
    [SerializeField] private CharacterController controller;

    //camera stuff
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;
    [SerializeField] private Transform cameraSpot;
    [SerializeField] private Canvas UICanvas;
    float xRotation;
    float yRotation;

    //Game inputs
    [SerializeField] private GameInputs gameInputs;

    //transforms 
    [SerializeField] private Transform cameraObject;
    [SerializeField] private Transform orientation;
    [SerializeField] public Transform heldObjectPos;

    //Layer masks
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private LayerMask InteractLayer;

    //Game Objects
    public Interactable heldObject;
    [SerializeField] private Interactable selectedInteractable;
    
    //Vectors
    private Vector3 velocity;
    
    //boolean values
    [SerializeField] private bool readyToJump;
    [SerializeField] private bool grounded;

    [SerializeField] private bool jump;
    //float values 
    [SerializeField] private float jumpCooldown;
    [SerializeField] private float groundDrag;
    [SerializeField] private float speed;
    [SerializeField] private float speedMultiplier;
    [SerializeField] private float jumpHeight = 5f;
    [SerializeField] private float groundedVectorLenght;
    [SerializeField] private float gravity;
    private float playerHeight = 2f;
    //UI values
    public float moneyAmount;
    [SerializeField] private Text moneyAmountText; 

    private void Awake(){
    
        if (Instance != null){
            Debug.LogError("More than one Player");
        }
        Instance = this;
    
    }

    private void Start(){
        rigid_body = GetComponent<Rigidbody>();

        gameInputs.OnInteract += GameInputs_OnInteractPerformed;
        gameInputs.OnAlternateInteract += GameInputs_OnAlternateInteractPerformed;

        gameInputs.OnJump += GameInputs_OnJumpPerformed; 
        gameInputs.OnSprintPerformed += GameInputs_OnSprintPerformed;
        gameInputs.OnSprintCanceled += GameInputs_OnSprintCancelled;

        speed = 7f;
        speedMultiplier = 1f;

        gravity = -9.81f;
        moneyAmount = 500;
        jump = false;
    }

    
    private void GameInputs_OnSprintPerformed(object sender, EventArgs e)
    {   if(grounded){
            speedMultiplier = 1.5f;
        }
    }

    private void GameInputs_OnSprintCancelled(object sender, EventArgs e)
    {
        speedMultiplier = 1f;
    }


    private void GameInputs_OnJumpPerformed(object sender, EventArgs e)
    {   
        if(grounded && readyToJump){
            jump = true;
        }
    }

    private void GameInputs_OnInteractPerformed(object sender, EventArgs e){
        if(selectedInteractable != null){
            selectedInteractable.Interact(this);
        }
    }

    private void GameInputs_OnAlternateInteractPerformed(object sender, EventArgs e){
        if(!heldObject.IsUnityNull()){

            NewTransformDropOrPickup(heldObject, null);

            heldObject.AddComponent<Rigidbody>();
            if (heldObject.TryGetComponent<Rigidbody>(out Rigidbody objectRigidBody) && heldObject.TryGetComponent<Collider>(out Collider objectCollider)){
                objectRigidBody.collisionDetectionMode = CollisionDetectionMode.Continuous;
                objectRigidBody.interpolation = RigidbodyInterpolation.Interpolate;       
                objectCollider.enabled = true;       
                objectRigidBody.mass = heldObject.GetMass();
                // objectRigidBody.AddForce((cameraObject.forward - cameraObject.position)*20f,ForceMode.Impulse);
                // Debug.Log(heldObject.GetTransform().position);
                // 
                heldObject = null;
            }else{
                Debug.Log("RAAAAH");
            }
        }
    }
    
    private void FixedUpdate(){
    }

    private void Update()
    {   
        groundedUpdate();
        InteractSelect();
        UpdateMoney();
    }


    private void LateUpdate(){
        CameraRotation();
        HandleMovement();
    }

    private void groundedUpdate(){
        grounded = Physics.Raycast(orientation.position, Vector3.down, playerHeight * 0.5f + groundedVectorLenght, whatIsGround);
        rigid_body.drag = grounded ? groundDrag : 0;
    }

    private void HandleMovement(){

        Vector2 inputVector = gameInputs.GetMovementVectorNormalized();
        
        if(grounded && velocity.y < 0){
            velocity.y = -2f;
        }

        Vector3 move = orientation.transform.right * inputVector.x + orientation.transform.forward * inputVector.y;
        controller.Move(move * speed * speedMultiplier * Time.deltaTime);
  
        if(jump){
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            jump = false;
            Invoke(nameof(ResetJump), jumpCooldown);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }   

    private void CameraRotation(){
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f,90f);
        cameraObject.transform.rotation = Quaternion.Euler(xRotation, yRotation,0);
        orientation.transform.rotation = Quaternion.Euler(0,yRotation,0);
    }


    private void InteractSelect(){

        RaycastHit hit;
        if (Physics.Raycast(cameraObject.position, cameraObject.forward, out hit, 3.5f, InteractLayer)){

            if(hit.transform.TryGetComponent(out Interactable hitSelected)){
                if(hitSelected != selectedInteractable){
                    SetSelected(hitSelected);
                }
            }
            else{
                SetSelected(null);
            }
        }
        else{
                SetSelected(null);
            }
    }
    
    private void UpdateMoney(){
        moneyAmountText.text = $"{moneyAmount}$";
    }

    private void SetSelected(Interactable selectedSoil){
        this.selectedInteractable = selectedSoil;
    }
    public bool PickUpObject(Interactable pickUpObject){
        if (heldObject.IsUnityNull()){

            heldObject = pickUpObject;

            if (heldObject.TryGetComponent<Rigidbody>(out Rigidbody objectRigidBody)){
                Destroy(objectRigidBody);
            }

            heldObject.transform.rotation = Quaternion.identity;
            NewTransformDropOrPickup(heldObject, heldObjectPos);

            return true;
        }else{
            return false;
        }
    }
    public bool SpawnAndPickUpObject(Interactable newObject){
        if (heldObject.IsUnityNull()){
            PickUpObject(Instantiate(newObject));
            return true;
        }else{
            return false;
        }
    }

    public void NewTransformDropOrPickup(Interactable newObject, Transform newParent){
        newObject.transform.SetParent(newParent, false);
        newObject.transform.position = heldObjectPos.position;
    }

    private void ResetJump(){
        readyToJump = true;
    }

}
