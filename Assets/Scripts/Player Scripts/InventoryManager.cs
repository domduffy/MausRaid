using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject player;
    public PlayerMovement playerScript;
    // Equippable Game Objeccts
    public GameObject batteryObject, gunObject, jetpackObject, meleeObject;
    // Equippable Locations
    public Transform batteryParentBone, gunParentBone, jetpackParentBone, meleeParentBone;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<PlayerMovement>();
        // get equippable locations
        batteryParentBone = playerScript.batteryLocation;
        gunParentBone = playerScript.gunLocation;
        jetpackParentBone = playerScript.jetpackLocation;
        meleeParentBone = playerScript.swordLocation;
        // Spawn objects
        batteryObject = Instantiate(batteryObject, batteryParentBone.transform.position, Quaternion.identity);
        gunObject = Instantiate(gunObject, gunParentBone.transform.position, gunParentBone.transform.rotation);
        jetpackObject = Instantiate(jetpackObject, jetpackParentBone.transform.position, Quaternion.identity);
        meleeObject = Instantiate(meleeObject, meleeParentBone.transform.position, meleeParentBone.transform.rotation);
        // set equippable parent bones
        batteryObject.transform.SetParent(batteryParentBone);
        gunObject.transform.SetParent(gunParentBone);
        jetpackObject.transform.SetParent(jetpackParentBone);
        meleeObject.transform.SetParent(meleeParentBone);
        // set equippable transforms
        /*batteryObject.transform.position = batteryParentBone.transform.position;
        batteryObject.transform.rotation = batteryParentBone.transform.rotation;
        gunObject.transform.position = gunParentBone.transform.position;
        gunObject.transform.rotation = gunParentBone.transform.rotation;
        jetpackObject.transform.position = jetpackParentBone.transform.position;
        jetpackObject.transform.rotation = jetpackParentBone.transform.rotation;
        meleeObject.transform.position = meleeParentBone.transform.position;
        meleeObject.transform.rotation = meleeParentBone.transform.rotation;*/
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
