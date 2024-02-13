using System;
using Enums;
using UnityEngine;

namespace GameFigures
{
    public class Bishop : Figure
    {
        
        private void Awake()
        {
            this.FigureType = EFigureType.Bishop;

            this.MovementSet.MovementTypeNw = EMovementType.Unlimited;
            this.MovementSet.MovementTypeN = EMovementType.NoMove;
            this.MovementSet.MovementTypeNe = EMovementType.Unlimited;
            this.MovementSet.MovementTypeW = EMovementType.NoMove;
            this.MovementSet.MovementTypeE = EMovementType.NoMove;
            this.MovementSet.MovementTypeSw = EMovementType.Unlimited;
            this.MovementSet.MovementTypeS = EMovementType.NoMove;
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