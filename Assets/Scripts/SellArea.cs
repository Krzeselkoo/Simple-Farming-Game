using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class SellArea : Interactable
{
    public Dictionary<string,float> cropPrices;

    private void Start(){
        cropPrices = new Dictionary<string, float>
        {
            { "Tomato", 5f }
        };
    }

    public override void Interact(Player player)
    {   
        if (!player.heldObject.IsUnityNull() && player.heldObject.TryGetComponent<Crop>(out Crop soldCrop)){
            if(cropPrices.ContainsKey(soldCrop.cropName)){
                player.moneyAmount += cropPrices[soldCrop.cropName];
                Destroy(player.heldObject.gameObject);
                player.heldObject = null;
            }
        }
    }
}

