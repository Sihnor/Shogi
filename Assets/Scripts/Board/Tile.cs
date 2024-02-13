using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    
    private int x;
    private int y;
    private Color color;
    
    public int GetX()
    {
        return this.x;
    }
    
    public int GetY()
    {
        return this.y;
    }
    
    public Color GetColor()
    {
        return this.color;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.renderer.material.color = this.color;
    }
    
    public void InitVariables(int x, int y, Color color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
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
