using System;
using Enums;
using Structs;
using UnityEngine;

namespace GameFigures
{
    public class HighlightFigure : MonoBehaviour
    {
        [SerializeField] private Figure FigureScript;
        private Color DefaultColor;
        private bool IsSelected;

        private void Awake()
        {
            Renderer component = GetComponent<Renderer>();
            this.DefaultColor = component.material.color;
            
            EventManager.Instance.FOnPieceSelected += OnPieceSelected;
            EventManager.Instance.FOnSelectedTile += OnSelectedTile;
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
            
            ToggleHighlight();
        }

        private void ToggleHighlight()
        {
            this.IsSelected = !this.IsSelected;
            Renderer component = GetComponent<Renderer>();
            component.material.color = this.IsSelected ? new Color(.4f, .4f, .4f, 1) : this.DefaultColor;
        }
        
        private void ResetHighlight()
        {
            this.IsSelected = false;
            Renderer component = GetComponent<Renderer>();
            component.material.color = this.DefaultColor;
        }
        
        private void OnPieceSelected(int x, int y, SFigureMovementSet movementSet, EFigureColor figureColor)
        {
            ResetHighlight();
        }
        
        private void OnSelectedTile(int x, int y)
        {
            if (!this.IsSelected) return;
            
            ResetHighlight();
            this.FigureScript.MoveFigure(x, y);
            transform.position = new Vector3(x, 0.1f, y);
            EventManager.Instance.OnPieceMoved();
        }
    }
}