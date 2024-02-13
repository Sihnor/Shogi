using System;
using Enums;

namespace GameFigures
{
    public class Silver : Figure
    {
        private void Awake()
        {
            this.FigureType = EFigureType.Silver;
            
            this.MovementSet.MovementTypeNw = EMovementType.Step;
            this.MovementSet.MovementTypeN = EMovementType.Step;
            this.MovementSet.MovementTypeNe = EMovementType.Step;
            this.MovementSet.MovementTypeW = EMovementType.NoMove;
            this.MovementSet.MovementTypeE = EMovementType.NoMove;
            this.MovementSet.MovementTypeSw = EMovementType.Step;
            this.MovementSet.MovementTypeS = EMovementType.NoMove;
            this.MovementSet.MovementTypeSe = EMovementType.Step;
        }
    }
}