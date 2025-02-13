using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable: MonoBehaviour 
{
    
    public float mass;
    public virtual void Interact(Player player){
        if(player.PickUpObject(this) && TryGetComponent<Collider>(out Collider collider)){
            collider.enabled = false;
        } 
    }

    public virtual Transform GetTransform(){
        return transform;
    }

    public virtual float GetMass(){
        return mass;
    }


}
