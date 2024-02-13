using System;
using Enums;

namespace GameFigures
{
    public class Pawn : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Pawn;

            this.MovementSet.MovementTypeNw = EMovementType.NoMove;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.NoMove;
            this.MovementSet.MovementTypeW = EMovementType.NoMove;
            this.MovementSet.MovementTypeE = EMovementType.NoMove;
            this.MovementSet.MovementTypeSw = EMovementType.NoMove;
            this.MovementSet.MovementTypeS = EMovementType.NoMove;
            this.MovementSet.MovementTypeSe = EMovementType.NoMove;
        }
    }
}