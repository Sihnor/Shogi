using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMouse : MonoBehaviour
{
    [SerializeField] private Tile TileDetails;
    [SerializeField] private bool CanBeHighlighted;
   
    public void OnMouseEnter()
    {
        if (!this.CanBeHighlighted) return;
        
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Color.magenta;
    }
    
    public void OnMouseExit()
    {
        if (!this.CanBeHighlighted) return;
        
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = this.TileDetails.GetCurrentColor();
    }
    
    public void OnMouseUp()
    {
        if (!this.CanBeHighlighted) return;
        
        Debug.Log("Mouse up: " + this.TileDetails.GetX() + ", " + this.TileDetails.GetY());
    }
}
