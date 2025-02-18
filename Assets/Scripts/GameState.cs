using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{   
    private int experience;
    private HashSet<string> boughtVegetables;
    [SerializeField] private Text experienceText;
    void Start()
    {
        experience = 0;
        boughtVegetables = new HashSet<string>();
    }

    void Update()
    {
        UpdateExperienceText();
    }

    public int GetExperience(){
        return experience;
    }

    public void AddExperience(int exp){
        experience += exp;
    }

    public bool BuyVegetable(string vegetableName, int vegetablePriceExp){
        if(boughtVegetables.Contains(vegetableName)){
            Debug.Log(vegetableName + " already bought");
            return false;
        }

        if(experience >= vegetablePriceExp){
            experience -= vegetablePriceExp;
            boughtVegetables.Add(vegetableName);
            return true;
        }else{
            Debug.Log("Not enough experience to buy " + vegetableName);
            return false;
        }
    }

    public void UpdateExperienceText(){
        experienceText.text = "EXP: " + experience;
    }

}
