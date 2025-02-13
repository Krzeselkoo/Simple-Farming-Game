using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : Interactable, IWaterSource
{
    public override void Interact(Player player)
    {   
        if(player.heldObject != null && player.heldObject.TryGetComponent<Bucket>(out Bucket bucket)){
            if(bucket.waterLevel < 1f){
                bucket.waterLevel += 0.25f;
            }
        }
    }
}
