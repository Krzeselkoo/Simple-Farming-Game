using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : Interactable
{

    [SerializeField] private GameObject computerScreen;

    public override void Interact(Player player)
    {   
        computerScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        player.setCantMove();
        player.getCameraObject().setCameraInactive();
        Debug.Log("Computer interacted");
    }
}
