using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance; //A static reference to the GameManager instance (not entirely sure why I need this rn but i had it in my last game)
    public GameObject playerGameObject;

    private Player player;
    private Item[] inventory;
    


    void Start()
    {
        Instance = this; //Setting the initial instance
        //StartGame(); //If I want a menu then this is essential
        
    }
    // Update is called once per frame
    void Update()
    {
        //player.SetLocation(playerGameObject.transform.position);
        
    }

    private void StartGame()
    {
        inventory = new Item[5];
        player = new Player(playerGameObject.transform.position, inventory);
    }

}
