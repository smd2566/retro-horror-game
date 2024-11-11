using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private Vector3 location;
    private Item[] inventory;

    public Player(Vector3 location, Item[] inventory)
    {
        this.location = location;
        this.inventory = inventory;
    }

    //Getters and setters
    public Vector3 GetLocation()
    {
        return location;
    }

    public void SetLocation(Vector3 location)
    {
        this.location = location;
    }

    public Item[] GetInventory()
    {
        return inventory;
    }

    public void SetInventory(Item[] inventory)
    {
        this.inventory = inventory;
    }
}
