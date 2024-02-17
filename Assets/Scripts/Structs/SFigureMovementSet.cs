using System.Collections.Generic;
using Enums;

namespace Structs
{
    public struct SFigureMovementSet
    {
        // 0 1 2
        // 3   5
        // 6 7 8
        public EMovementType MovementTypeNw;
        public EMovementType MovementTypeN;
        public EMovementType MovementTypeNe;
        public EMovementType MovementTypeW;
        public EMovementType MovementTypeE;
        public EMovementType MovementTypeSw;
        public EMovementType MovementTypeS;
        public EMovementType MovementTypeSe;

        public IEnumerable<EMovementType> GetEnumerator()
        {
            yield return this.MovementTypeNw;
            yield return this.MovementTypeN;
            yield return this.MovementTypeNe;
            yield return this.MovementTypeW;
            yield return this.MovementTypeE;
            yield return this.MovementTypeSw;
            yield return this.MovementTypeS;
            yield return this.MovementTypeSe;
        }
    }
}