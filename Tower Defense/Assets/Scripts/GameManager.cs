using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject buildTile;

    void Start()
    {
        GridController grid = new GridController(4, 4, 10f, buildTile);
    }

    
    void Update()
    {
        
    }
}
