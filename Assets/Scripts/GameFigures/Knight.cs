using System;
using Enums;

namespace GameFigures
{
    public class Knight : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Knight;

            this.MovementSet.MovementTypeNw = EMovementType.NoMove;
            this.MovementSet.MovementTypeN = EMovementType.Jump;
            this.MovementSet.MovementTypeNe = EMovementType.NoMove;
            this.MovementSet.MovementTypeW = EMovementType.NoMove;
            this.MovementSet.MovementTypeE = EMovementType.NoMove;
            this.MovementSet.MovementTypeSw = EMovementType.NoMove;
            this.MovementSet.MovementTypeS = EMovementType.NoMove;
            this.MovementSet.MovementTypeSe = EMovementType.NoMove;
        }
    }
}