using System;
using System.Collections;
using System.Collections.Generic;
using Enums;
using GameFigures;
using Structs;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    
    public event Action<bool> FOnOverViewModeChange;
    public event Action<int, int, SFigureMovementSet, EFigureColor> FOnPieceSelected;

    public event Action<int, int> FOnSelectedTile;  
    public event Action FOnPieceMoved;
    
    private void Awake()
    {
        if (Instance != null) return;
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    /// <summary>
    /// Will be called when the overview mode is changed
    /// </summary>
    /// <param name="overviewMode">true is now in overview</param>
    public void OnOverViewModeChange(bool overviewMode)
    {
        FOnOverViewModeChange?.Invoke(overviewMode);
    }
    
    public void OnPieceSelected(int x, int y, SFigureMovementSet movementSet, EFigureColor figureColor)
    {
        FOnPieceSelected?.Invoke(x, y, movementSet, figureColor);
    }
    
    public void OnSelectedTile(int x, int y)
    {
        FOnSelectedTile?.Invoke(x, y);
    }
    
    public void OnPieceMoved()
    {
        FOnPieceMoved?.Invoke();
    }
}
