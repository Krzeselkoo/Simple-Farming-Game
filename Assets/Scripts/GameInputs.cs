using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class GameInputs : MonoBehaviour
{
    private PlayerInputs playerInputs; 
    public event EventHandler OnJump;
    public event EventHandler OnInteract;
    public event EventHandler OnAlternateInteract;
    public event EventHandler OnSprintPerformed;
    public event EventHandler OnSprintCanceled;
    private void Awake(){
        playerInputs = new PlayerInputs();
        playerInputs.PlayerI.Enable();

        playerInputs.PlayerI.Jump.performed += Jump_performed;
        playerInputs.PlayerI.Interact.performed += Interact_performed;
        playerInputs.PlayerI.AlternateInteract.performed += AlternateInteract_performed;
        playerInputs.PlayerI.Sprint.performed += Sprint_performed;
        playerInputs.PlayerI.Sprint.canceled += Sprint_canceled;
        
    }

    
    


    private void Interact_performed(InputAction.CallbackContext context)
    {
        OnInteract?.Invoke(this, EventArgs.Empty);
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        OnJump?.Invoke(this, EventArgs.Empty);
    }

    private void AlternateInteract_performed(InputAction.CallbackContext context){
        OnAlternateInteract?.Invoke(this, EventArgs.Empty);
    }

    private void Sprint_performed(InputAction.CallbackContext context)
    {
        OnSprintPerformed?.Invoke(this, EventArgs.Empty);
    }

    private void Sprint_canceled(InputAction.CallbackContext context)
    {
        OnSprintCanceled?.Invoke(this, EventArgs.Empty);
    }

    private void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public Vector2 GetMovementVectorNormalized(){
        Vector2 inputVector = playerInputs.PlayerI.Movement.ReadValue<Vector2>();
        return inputVector;
    }
}
