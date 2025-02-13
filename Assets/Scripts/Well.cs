using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : Interactable, IWaterSource
{
    public override void Interact(Player player)
    {   
        if(player.heldObject != null && player.heldObject.TryGetComponent<Bucket>(out Bucket bucket)){
            bucket.fillBucketPartially();
        }
    }
}
