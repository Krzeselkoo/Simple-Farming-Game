using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : Interactable
{
    public override void Interact(Player player)
    {   
        player.setCantMove();
        player.getCameraObject().setCameraInactive();
        Debug.Log("Computer interacted");
    }
}
