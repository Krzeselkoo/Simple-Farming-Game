using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Soil : Interactable, ISeedParent 
{   
    //SerializedFields

    [SerializeField] private float growTime;

    //Stopwatch

    private Stopwatch stopWatch;

    //Transforms
    [SerializeField] private GameObject dirt;
    public Transform placeSpot;
    public Transform seedSpot;

    //Interactable objects

    private Interactable grownCrop;
    public Interactable seedObject; 

    //Components of Interactables

    private Crop crop;
    public Seed seed;

    //bool values

    public bool isWatered;
    private bool isGrowingCrop;

    //Materials  

    [SerializeField] private Material wateredMaterial;
    [SerializeField] private Material notWateredMaterial;
    //==========================================================================================

    private void Start(){
        setNotWatered();
        isGrowingCrop = false;
        stopWatch = new Stopwatch();
        growTime = 5f;
    }

    private void Update(){        
        WaterManagement();
    }

    public override void Interact(Player player)
    {
        if(player.heldObject != null){
            if (seedObject == null && player.heldObject.TryGetComponent<Seed>(out seed)){ 
                seedObject = player.heldObject;

                if(!stopWatch.IsRunning){   
                    stopWatch.Reset();
                    stopWatch.Start();
                }
                

                seedObject.transform.SetParent(seedSpot, false);
                player.heldObject = null;
            }
            
            else if(player.heldObject.TryGetComponent<Spade>(out Spade spade) && seedObject != null ){
                DestroySeedObject();
                StopwatchStopAndReset(stopWatch);
                isGrowingCrop = false;
                setNotWatered();
            }
            else if(player.heldObject.TryGetComponent<Bucket>(out Bucket bucket) && bucket.waterLevel >= 0.25f){
                setWatered();
                if(isWatered){
                    stopWatch.Reset();
                }
                setWatered();
                bucket.waterLevel -= 0.25f;
            }

        }else{
            if(grownCrop != null && grownCrop.TryGetComponent<Crop>(out crop)){
                if(player.PickUpObject(grownCrop)){
                    grownCrop = null;
                }
            }
        }
    } 

    private void DestroySeedObject(){
        Destroy(seedObject.gameObject);
        seed = null;
        seedObject = null;
    }

    private void Grow(){
        if(seedObject != null && isGrowingCrop){
            grownCrop = Instantiate(seed.GetFruit());
            grownCrop.transform.SetParent(placeSpot, false);
            DestroySeedObject();
            setNotWatered();
            isGrowingCrop = false;
        }
    }

    private void WaterManagement(){
        
        if (seedObject != null){
            if(!isWatered && stopWatch.IsRunning && stopWatch.Elapsed.Seconds > 5f){
                DestroySeedObject();
                StopwatchStopAndReset(stopWatch);
            }else if(isWatered){
                if(stopWatch.IsRunning){
                    stopWatch.Stop();
                }
                stopWatch.Reset();
                if(!isGrowingCrop){
                    isGrowingCrop = true;
                    Invoke(nameof(Grow), growTime);
                    UnityEngine.Debug.Log("Now we are here huh");
                }
            }
        }else{
            if(isWatered){
                if(!stopWatch.IsRunning){
                    stopWatch.Reset();
                    stopWatch.Start();
                }else if(stopWatch.Elapsed.Seconds > 10f){
                    setNotWatered();
                    StopwatchStopAndReset(stopWatch);
                }
            }
        }
    }

    private void setWatered(){
        isWatered = true;
        dirt.GetComponent<MeshRenderer>().material = wateredMaterial;
    }

    private void setNotWatered(){
        isWatered = false;
        dirt.GetComponent<MeshRenderer>().material = notWateredMaterial;
    }


    private void StopwatchStopAndReset(Stopwatch stopwatch){
        stopwatch.Stop();
        stopwatch.Reset();
    }

}
