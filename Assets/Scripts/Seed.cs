using Unity.VisualScripting;
using UnityEngine;

public class Seed : Interactable
{
    [SerializeField] private Interactable seedFruit;
    public Transform seedTransform;
    public Transform parentTransform;

    public void Start(){
        mass = 1f;
    }

    private void Update(){
        parentTransform = transform.parent;    
    }

    public Interactable GetFruit(){
        return seedFruit;
    }

}
