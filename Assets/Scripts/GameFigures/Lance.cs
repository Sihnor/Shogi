using System;

namespace GameFigures
{
    public class Lance : Figure
    {
        private void Awake()
        {
            this.FigureType = Enums.EFigureType.Lance;

            this.MovementSet.MovementTypeNw = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeN = Enums.EMovementType.Unlimited;
            this.MovementSet.MovementTypeNe = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeW = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeE = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeSw = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeS = Enums.EMovementType.NoMove;
            this.MovementSet.MovementTypeSe = Enums.EMovementType.NoMove;
        }
    }
}