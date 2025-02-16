using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCloseButton : MonoBehaviour
{
    [SerializeField] private GameObject computerScreen;
    [SerializeField] private Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        computerScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.setCanMove();
        player.getCameraObject().setCameraActive();
    }
}
