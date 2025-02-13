using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObject : MonoBehaviour
{   
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;
    [SerializeField] private Transform orientation;
    float xRotation;
    float yRotation;
    public void Update(){
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f,90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation,0);
        orientation.transform.rotation = Quaternion.Euler(0,yRotation,0);
    } 
}
