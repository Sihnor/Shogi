using System;
using Enums;
using Structs;
using UnityEngine;

namespace GameFigures
{
    public class HighlightFigure : MonoBehaviour
    {
        private Color DefaultColor;
        private bool IsSelected;

        private void Awake()
        {
            Renderer component = GetComponent<Renderer>();
            this.DefaultColor = component.material.color;
            
            EventManager.Instance.FOnPieceSelected += OnPieceSelected;
        }

        private void OnMouseEnter()
        {
            if (this.IsSelected) return;
            
            Renderer component = GetComponent<Renderer>();
            component.material.color = new Color(.5f, .5f, .5f, 1);
        }

        private void OnMouseExit()
        {
            if (this.IsSelected) return;
            
            Renderer component = GetComponent<Renderer>();
            component.material.color = this.DefaultColor;
        }

        private void OnMouseUp()
        {
            Figure parent = GetComponentInParent<Figure>();
            EventManager.Instance.OnPieceSelected(parent.GetCurrentX(), parent.GetCurrentY(), parent.GetMovement(), parent.GetFigureColor());
            
            this.IsSelected = !this.IsSelected;
            Renderer component = GetComponent<Renderer>();
            component.material.color = this.IsSelected ? new Color(.4f, .4f, .4f, 1) : this.DefaultColor;
        }
        
        private void OnPieceSelected(int x, int y, SFigureMovementSet movementSet, EFigureColor figureColor)
        {
            this.IsSelected = false;
            Renderer component = GetComponent<Renderer>();
            component.material.color = this.DefaultColor;
        }
    }
}