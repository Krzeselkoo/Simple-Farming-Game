using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spade : Interactable
{
    public string objectName;

    private void Start(){
        objectName = "Spade";
        mass = 7_500f;
    }

}
