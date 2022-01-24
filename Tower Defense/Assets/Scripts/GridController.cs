using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController  { 

    

    public GridController(int width, int height, float cellSize, GameObject buildTile)
    {
       

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject.Instantiate(buildTile, new Vector3((x * cellSize), 0, (z * cellSize)), Quaternion.identity);
            }
        }
      

    }
    
}
