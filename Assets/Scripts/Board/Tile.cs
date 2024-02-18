using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Renderer TileRenderer;
    private Color OriginalColor;
    private Color CurrentColor;
    
    private int XCoordinate;
    private int YCoordinate;
    private bool IsHighlighted;
    
    public int GetX()
    {
        return this.XCoordinate;
    }
    
    public int GetY()
    {
        return this.YCoordinate;
    }
    
    public Color GetCurrentColor()
    {
        return this.CurrentColor;
    }
    
    public bool GetIsHighlighted()
    {
        return this.IsHighlighted;
    }

    private void Awake()
    {
        EventManager.Instance.FOnPieceMoved += ResetColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.TileRenderer.material.color = this.CurrentColor;
    }
    
    public void InitVariables(int x, int y, Color color)
    {
        this.XCoordinate = x;
        this.YCoordinate = y;
        this.OriginalColor = color;
        this.CurrentColor = color;
    }

    public void HighlightTile(Color color)
    {
        this.TileRenderer.material.color = color;
        this.IsHighlighted = true;
    }
    
    public void ResetColor()
    {
        this.TileRenderer.material.color = this.OriginalColor;
        this.IsHighlighted = false;
    }
    
}
