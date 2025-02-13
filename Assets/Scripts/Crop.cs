using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crop : Interactable
{
    public string cropName;
    public Transform cropTransform;
    
    public void Start(){
        mass = 10f;
    }

}
