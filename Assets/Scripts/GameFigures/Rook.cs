using System;
using Enums;

namespace GameFigures
{
    public class Rook : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Rook;

            this.MovementSet.MovementTypeNw = EMovementType.NoMove;
            this.MovementSet.MovementTypeN = EMovementType.Unlimited;
            this.MovementSet.MovementTypeNe = EMovementType.NoMove;
            this.MovementSet.MovementTypeW = EMovementType.Unlimited;
            this.MovementSet.MovementTypeE = EMovementType.Unlimited;
            this.MovementSet.MovementTypeSw = EMovementType.NoMove;
            this.MovementSet.MovementTypeS = EMovementType.Unlimited;
            this.MovementSet.MovementTypeSe = EMovementType.NoMove;
        }
    }
}