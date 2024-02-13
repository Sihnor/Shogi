﻿using System;
using Enums;

namespace GameFigures
{
    public class Tokin : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Tokin;

            this.MovementSet.MovementTypeNw = EMovementType.Step;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.Step;
            this.MovementSet.MovementTypeW = EMovementType.Step;
            this.MovementSet.MovementTypeE = EMovementType.Step;
            this.MovementSet.MovementTypeSw = EMovementType.NoMove;
            this.MovementSet.MovementTypeS = EMovementType.Step;
            this.MovementSet.MovementTypeSe = EMovementType.NoMove;
        }
    }
}