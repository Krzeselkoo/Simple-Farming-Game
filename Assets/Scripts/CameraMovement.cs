using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraHolder;

    void Update()
    {
        transform.position = cameraHolder.position;
    }
}
