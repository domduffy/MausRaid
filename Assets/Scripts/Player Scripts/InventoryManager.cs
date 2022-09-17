using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject player;
    public PlayerMovement playerScript;
    // Equippable Game Objects
    public GameObject batteryObject;
    public GameObject gunObject;
    public GameObject jetpackObject;
    public GameObject meleeObject;

    // Equippable Game Objects
    private GameObject myBatteryObject, myGunObject, myJetpackObject, myMeleeObject;
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
        Debug.Log(playerScript.jetpackLocation.transform.rotation);
        meleeParentBone = playerScript.swordLocation;
        // Spawn objects
        myBatteryObject = Instantiate(batteryObject, batteryParentBone.transform.position, Quaternion.identity);
        myGunObject = Instantiate(gunObject, gunParentBone.transform.position, gunParentBone.transform.rotation);
        myJetpackObject = Instantiate(jetpackObject, jetpackParentBone.transform.position, jetpackParentBone.transform.rotation);
        myMeleeObject = Instantiate(meleeObject, meleeParentBone.transform.position, meleeParentBone.transform.rotation);
        // set equippable parent bones
        myBatteryObject.transform.SetParent(batteryParentBone);
        myGunObject.transform.SetParent(gunParentBone);
        myJetpackObject.transform.SetParent(jetpackParentBone);
        myMeleeObject.transform.SetParent(meleeParentBone);
        // set equippable transforms
        //batteryObject.transform.position = batteryParentBone.transform.position;
        //batteryObject.transform.rotation = batteryParentBone.transform.rotation;
        //gunObject.transform.position = gunParentBone.transform.position;
        //gunObject.transform.rotation = gunParentBone.transform.rotation;
        //jetpackObject.transform.position = jetpackParentBone.transform.position;
        myJetpackObject.transform.rotation = jetpackParentBone.transform.rotation;
        //meleeObject.transform.position = meleeParentBone.transform.position;
        //meleeObject.transform.rotation = meleeParentBone.transform.rotation;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
