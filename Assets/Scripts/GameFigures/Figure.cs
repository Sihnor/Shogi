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

        protected int CurrentX;
        protected int CurrentY;
        
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
        
        public void MoveFigure(int x, int y)
        {
            this.CurrentX = x;
            this.CurrentY = y;
            
            transform.position = new Vector3(x, 0.1f, y);
        }
    }
}