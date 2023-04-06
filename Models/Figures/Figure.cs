using System;
using Tetris.Enums;
using Tetris.Models.Contracts;

namespace Tetris.Models.Figures
{
    public abstract class Figure : IFigure
    {
        private int height;
        private int width;

        protected Figure(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        
        public int Height => height;

        public int Width => width;

        
    }
}