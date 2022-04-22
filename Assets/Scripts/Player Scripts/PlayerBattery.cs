using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattery : PlayerEquippables
{
    ScriptableObject batteryScriptable;
    InventoryManager inventoryManager;
    GameObject player;
    PlayerMovement playerMovement;

    Transform newParentBone;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
        newParentBone = playerMovement.batteryLocation;
        transform.position = newParentBone.transform.position;
        SetLocation(newParentBone);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
