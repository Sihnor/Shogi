using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Renderer TileRenderer;
    private Color OriginalColor;
    private Color CurrentColor;
    
    private int x;
    private int y;
    
    public int GetX()
    {
        return this.x;
    }
    
    public int GetY()
    {
        return this.y;
    }
    
    public Color GetCurrentColor()
    {
        return this.CurrentColor;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.TileRenderer.material.color = this.CurrentColor;
    }
    
    public void InitVariables(int x, int y, Color color)
    {
        this.x = x;
        this.y = y;
        this.OriginalColor = color;
        this.CurrentColor = color;
    }

    public void SetColor(Color color)
    {
        this.TileRenderer.material.color = color;
    }
    
    public void ResetColor()
    {
        this.TileRenderer.material.color = this.OriginalColor;
    }
    
    public void OnMouseDown()
    {
        Debug.Log("Tile clicked: " + this.x + ", " + this.y);
    }
    
    public void OnMouseEnter()
    {
        Debug.Log("Mouse entered: " + this.x + ", " + this.y);
    }
    
    public void OnMouseExit()
    {
        Debug.Log("Mouse exited: " + this.x + ", " + this.y);
    }
    
    public void OnMouseUp()
    {
        Debug.Log("Mouse up: " + this.x + ", " + this.y);
    }
    
    public void OnMouseOver()
    {
        Debug.Log("Mouse over: " + this.x + ", " + this.y);
    }
    
    public void OnMouseUpAsButton()
    {
        Debug.Log("Mouse up as button: " + this.x + ", " + this.y);
    }
    
    public void OnMouseDrag()
    {
        Debug.Log("Mouse drag: " + this.x + ", " + this.y);
    }
}
