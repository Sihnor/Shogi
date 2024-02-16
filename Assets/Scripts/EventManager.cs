using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    
    public event Action<bool> FOnOverViewModeChange;
    public event Action FOnPieceSelected;

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
    
    public void OnPieceSelected()
    {
        FOnPieceSelected?.Invoke();
    }
}
