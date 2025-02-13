using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SeedContainer : Interactable
{
    [SerializeField] private Interactable seedGiven;

    public override void Interact(Player player){
        if (seedGiven != null){
            player.SpawnAndPickUpObject(seedGiven);
        }else{
            Debug.LogError("No seed assigned to the container");
        }
    }
}
