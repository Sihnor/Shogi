using System;
using Enums;
using Structs;
using UnityEngine;

namespace GameFigures
{
    public abstract class Figure : MonoBehaviour
    {
        protected EFigureType FigureType;
        protected EFigureColor FigureColor;
        protected Color FigureColorRGB;
    
        protected SFigureMovementSet MovementSet = new SFigureMovementSet();

        public int CurrentX;
        public int CurrentY;
        
        public void SetFigureColor(EFigureColor figureColor)
        {
            this.FigureColor = figureColor;
        }
    }
}