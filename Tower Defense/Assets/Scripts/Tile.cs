using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public Color color;
    private Color startColor;
    private Renderer render;

    

    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseDown()
    {
        //build turret here
    }

    void OnMouseEnter()
    {
        render.material.color = color;
    }

    void OnMouseExit()
    {
        render.material.color = startColor;
    }
}
