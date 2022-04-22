using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject[] players;
    public GameObject spawnPoint;

    InventoryManager inventoryManager;

    private void Awake()
    {
        // find every player, store them in array - player 0 will be player 1
        // get the inventory manager
        // get the spawn manager
        // spawn the player at a spawn point
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Instance != null && Instance!= this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
}
