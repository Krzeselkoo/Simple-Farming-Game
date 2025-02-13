using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObject : MonoBehaviour, ICameraObject
{   
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;
    [SerializeField] private Transform orientation;
    [SerializeField] private bool canRotate = true;
    float xRotation;
    float yRotation;
    public void Update(){
        if(canRotate){
            float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

            yRotation += mouseX;
            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90f,90f);
            transform.rotation = Quaternion.Euler(xRotation, yRotation,0);
            orientation.transform.rotation = Quaternion.Euler(0,yRotation,0);
        } 
    }

    public void setCameraActive(){
        canRotate = true;
    }

    public void setCameraInactive(){
        canRotate = false;
    }
}
