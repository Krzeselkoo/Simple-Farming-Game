using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class SellArea : Interactable
{
    public Dictionary<string,float> cropPrices;
    public Dictionary<string, int> cropExp;
    [SerializeField] private GameObject gameState;
    private void Start(){
        cropPrices = new Dictionary<string, float>
        {
            { "Tomato", 5f },
            { "Cucumber", 10f },
            { "Cabbage", 20f },
            { "Carrot", 40f }
        };

        cropExp = new Dictionary<string, int>
        {
            { "Tomato", 1 },
            { "Cucumber", 2 },
            { "Cabbage", 4 },
            { "Carrot", 8 }
        };
    }

    public override void Interact(Player player)
    {   
        if (!player.heldObject.IsUnityNull() && player.heldObject.TryGetComponent<Crop>(out Crop soldCrop)){
            if(cropPrices.ContainsKey(soldCrop.cropName)){
                player.moneyAmount += cropPrices[soldCrop.cropName];
                gameState.GetComponent<GameState>().AddExperience(cropExp[soldCrop.cropName]);
                Destroy(player.heldObject.gameObject);
                player.heldObject = null;
            }
        }
    }
}

