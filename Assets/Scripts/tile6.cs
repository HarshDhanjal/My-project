using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile6 : MonoBehaviour
{
    public int tileID;  // Unique identifier for the tile
    public Vector3 position;  // Position of the tile in the grid

    // Additional information about the tile can be added here
    public string tileType = "GRASS BLOCK"; //The type of tile
    public bool isWalkable = true; // Is the tile obstructed or not
    public int tilevalue = 0; // Value of resources on that tile

    void Start()
    {
        // Example: Assigning a unique ID based on position
        tileID = (int)(position.x * 10 + position.z);
    }
}
