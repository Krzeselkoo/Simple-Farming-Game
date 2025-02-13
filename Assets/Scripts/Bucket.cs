using System;
using Unity.VisualScripting;
using UnityEngine;

public class Bucket : Interactable
{
    public float waterLevel;

    private void Start(){
        waterLevel = 0f;
        mass = 6_000f;
    }

    public void fillBucketPartially(){
        if(waterLevel < 1f){
            waterLevel += 0.25f;
        }
        waterLevel = Mathf.Clamp(waterLevel, 0, 1f);
        Debug.Log("Water level: " + waterLevel);
    }


}
