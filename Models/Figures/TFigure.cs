using System;
using Tetris.Enums;
using Tetris.Models.Contracts;

namespace Tetris.Models.Figures
{
    public class TFigure : Figure, IRotate
    {
        private const int TFigureHeight = 3;
        private const int TFigureWidth = 2;
        private Direction currentDirection = Direction.up;

        public TFigure()
            : base(TFigureHeight, TFigureWidth)
        {
        }

        public void RotateFigure()
        {
            switch (currentDirection)
            {
                case Direction.up:
                    currentDirection = Direction.right;
                    break;
                case Direction.right:
                    currentDirection = Direction.down;
                    break;
                case Direction.down:
                    currentDirection = Direction.left;
                    break;
                case Direction.left:
                    currentDirection = Direction.up;
                    break;
            }
        }

        public void Draw(int startColumn, int startRow)
        {
            switch (currentDirection)
            {
                case Direction.up:
                    Console.SetCursorPosition(startColumn, startRow);
                    Console.Write("□■□");
                    Console.SetCursorPosition(startColumn, startRow + 1);
                    Console.Write("■■■");

                    break;
                case Direction.right:
                    Console.SetCursorPosition(startColumn, startRow);
                    Console.Write("■□");
                    Console.SetCursorPosition(startColumn, startRow + 1);
                    Console.Write("■■");
                    Console.SetCursorPosition(startColumn, startRow + 2);
                    Console.Write("■□");
                    break;

                case Direction.down:
                    Console.SetCursorPosition(startColumn, startRow + 1);
                    Console.Write("■■■");
                    Console.SetCursorPosition(startColumn, startRow + 2);
                    Console.Write("□■□");
                    break;

                case Direction.left:
                    Console.SetCursorPosition(startColumn + 1, startRow);
                    Console.Write("□■");
                    Console.SetCursorPosition(startColumn + 1, startRow + 1);
                    Console.Write("■■");
                    Console.SetCursorPosition(startColumn + 1, startRow + 2);
                    Console.Write("□■");
                    break;
            }
        }

    }
}