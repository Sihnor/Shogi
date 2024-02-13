using System;
using Enums;
using UnityEngine;

namespace GameFigures
{
    public class Gold : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Gold;

            this.MovementSet.MovementTypeNw = EMovementType.Step;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.Step;
            this.MovementSet.MovementTypeW = EMovementType.Step;
            this.MovementSet.MovementTypeE = EMovementType.Step;
            this.MovementSet.MovementTypeSw = EMovementType.NoMove;
            this.MovementSet.MovementTypeS = EMovementType.Step;
            this.MovementSet.MovementTypeSe = EMovementType.NoMove;
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