using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMouse : MonoBehaviour
{
    [SerializeField] private Tile TileDetails;
   
    public void OnMouseUp()
    {
        if (!this.TileDetails.GetIsHighlighted()) return;
        
        EventManager.Instance.OnSelectedTile(this.TileDetails.GetX(), this.TileDetails.GetY());
        this.TileDetails.ResetColor();
    }
}
