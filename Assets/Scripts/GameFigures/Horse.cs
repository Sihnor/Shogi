using System;
using Enums;
using UnityEngine;

namespace GameFigures
{
    public class Horse : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Horse;

            this.MovementSet.MovementTypeNw = EMovementType.Unlimited;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.Unlimited;
            this.MovementSet.MovementTypeW = EMovementType.Step;
            this.MovementSet.MovementTypeE = EMovementType.Step;
            this.MovementSet.MovementTypeSw = EMovementType.Unlimited;
            this.MovementSet.MovementTypeS = EMovementType.Step;
            this.MovementSet.MovementTypeSe = EMovementType.Unlimited;
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