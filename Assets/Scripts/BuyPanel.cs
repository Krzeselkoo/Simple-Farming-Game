using UnityEngine;
using UnityEngine.UI;

public class BuyPanel: MonoBehaviour
{
    [SerializeField] private GameObject gameState;
    [SerializeField] private string vegetableName;
    [SerializeField] private int vegetablePriceExp;
    public void Buy(){
        if(gameState.GetComponent<GameState>().BuyVegetable(vegetableName, vegetablePriceExp)){
            Debug.Log("Bought " + vegetableName);
        }
    }
} 
