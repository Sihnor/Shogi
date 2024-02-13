using System;
using Enums;
using UnityEngine;

namespace GameFigures
{
    public class Dragon : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Dragon;

            this.MovementSet.MovementTypeNw = EMovementType.Step;
            this.MovementSet.MovementTypeN = EMovementType.Unlimited;
            this.MovementSet.MovementTypeNe = EMovementType.Step;
            this.MovementSet.MovementTypeW = EMovementType.Unlimited;
            this.MovementSet.MovementTypeE = EMovementType.Unlimited;
            this.MovementSet.MovementTypeSw = EMovementType.Step;
            this.MovementSet.MovementTypeS = EMovementType.Unlimited;
            this.MovementSet.MovementTypeSe = EMovementType.Step;
        }
        
        protected void OnMouseEnter()
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Color.grey;
        }

        protected void OnMouseExit()
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = this.FigureColorRGB;
        }
    }
}