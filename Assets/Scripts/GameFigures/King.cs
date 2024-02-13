using System;
using Enums;

namespace GameFigures
{
    public class King : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.King;

            this.MovementSet.MovementTypeNw = EMovementType.Step;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.Step;
            this.MovementSet.MovementTypeW = EMovementType.Step;
            this.MovementSet.MovementTypeE = EMovementType.Step;
            this.MovementSet.MovementTypeSw = EMovementType.Step;
            this.MovementSet.MovementTypeS = EMovementType.Step;
            this.MovementSet.MovementTypeSe = EMovementType.Step;
        }
    }
}