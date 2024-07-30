using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmanager : MonoBehaviour
{
    public GameObject cubePrefab;  // Reference to the cube prefab
    public int gridSize = 10;  // Size of the grid

    void Start()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int z = 0; z < gridSize; z++)
            {
                Vector3 position = new Vector3(x, 0, z);
                GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity);
                cube.GetComponent<TileInfo>().position = position;
                // Additional initialization can be added here
            }
        }
    }
}
