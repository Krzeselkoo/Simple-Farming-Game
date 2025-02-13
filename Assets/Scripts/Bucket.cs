using Unity.VisualScripting;
using UnityEngine;

public class Bucket : Interactable
{
    public float waterLevel;

    private void Start(){
        waterLevel = 0f;
        mass = 6_000f;
    }

}
