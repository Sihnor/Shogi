using System;
using Enums;
using Structs;
using UnityEngine;

namespace GameFigures
{
    public abstract class Figure : MonoBehaviour
    {
        protected EFigureType FigureType;
        public EFigureColor FigureColor;
        protected Color FigureColorRGB;
    
        protected SFigureMovementSet MovementSet = new SFigureMovementSet();

        public int CurrentX;
        public int CurrentY;
        
        public int GetCurrentX()
        {
            return this.CurrentX;
        }
        
        public int GetCurrentY()
        {
            return this.CurrentY;
        }
        
        public EFigureType GetFigureType()
        {
            return this.FigureType;
        }
        
        public EFigureColor GetFigureColor()
        {
            return this.FigureColor;
        }
        
        public SFigureMovementSet GetMovement()
        {
            return this.MovementSet;
        }
        
        public void SetFigureColor(EFigureColor figureColor)
        {
            this.FigureColor = figureColor;
        }
        
        public void InitVariables(int x, int y, EFigureColor figureColor)
        {
            this.CurrentX = x;
            this.CurrentY = y;
            this.FigureColor = figureColor;
        }
    }
}