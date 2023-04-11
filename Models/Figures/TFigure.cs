using System;
using Tetris.Enums;
using Tetris.Models.Contracts;

namespace Tetris.Models.Figures;

public class TFigure : Figure
{
    public override void Draw(int startColumn, int startRow)
    {
        switch (this.Direction)
        {
            case Direction.up:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("██████");
                break;

            case Direction.left:
                Console.SetCursorPosition(startColumn + 2, startRow);
                Console.Write("██[]");
                Console.SetCursorPosition(startColumn + 2, startRow + 1);
                Console.Write("████");
                Console.SetCursorPosition(startColumn + 2, startRow + 2);
                Console.Write("██[]");
                break;

            case Direction.right:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]██");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("████");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]██");
                break;

            case Direction.down:
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("██████");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]██[]");
                break;
        }
    }

    public override void Rotate()
    {
        switch (Direction)
        {
            case Direction.up:
                Direction = Direction.right;
                break;
            case Direction.right:
                Direction = Direction.down;
                break;
            case Direction.down:
                Direction = Direction.left;
                break;
            case Direction.left:
                Direction = Direction.up;
                break;
        }
    }
}