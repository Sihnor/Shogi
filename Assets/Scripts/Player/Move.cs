using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private InputAction MoveAction;
    private InputAction OverviewAction;
    
    
    private Vector3 OldPosition;
    private Vector3 OverviewPosition = new Vector3(4, 9, 4);
    private bool OverviewMode = false;
    //4 0 4
    private void Awake()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        
        this.MoveAction = playerInput.actions["Move"];
        this.MoveAction.performed += ctx => MoveActionHandler(ctx.ReadValue<Vector2>());
        
        this.OverviewAction = playerInput.actions["Overview"];
        this.OverviewAction.started += ctx => OverviewActionHandlerStart();
        this.OverviewAction.canceled += ctx => OverviewActionHandlerStop();
    }
    
    private void MoveActionHandler(Vector2 direction)
    {
        transform.position += new Vector3(direction.y, 0, direction.x);
    }
    
    private void OverviewActionHandlerStart()
    {
        this.OverviewMode = !this.OverviewMode;
        
        EventManager.Instance.OnOverViewModeChange(this.OverviewMode);
        
        if (this.OverviewMode)
        {
            this.OldPosition = transform.position;
            transform.position = this.OverviewPosition;
        }
        else
        {
            transform.position = this.OldPosition;
        }
    }
    
    private void OverviewActionHandlerStop()
    {
        
        return;
        transform.position = this.OldPosition;
    }
}
