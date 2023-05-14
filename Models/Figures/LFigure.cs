using System;
using Tetris.Enums;

namespace Tetris.Models.Figures;

public class LFigure : Figure
{
    private const int LHeight = 3;
    private const int LWidth = 3;

    public LFigure() : base(LHeight, LWidth)
    {
    }
    
    public override void Draw(int startColumn, int startRow)
    {
        switch (this.Direction)
        {
            case Direction.up:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("████[]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]██[]");
                break;

            case Direction.left:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[][]██");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("██████");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[][][]");
                break;

            case Direction.right:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[][][]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("██████");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("██[][]");
                break;

            case Direction.down:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]████");
                break;
        }
    }

    public override void Rotate()
    {
        switch (Direction)
        {
            case Direction.up:
                Direction = Direction.left;
                break;
            case Direction.right:
                Direction = Direction.up;
                break;
            case Direction.down:
                Direction = Direction.right;
                break;
            case Direction.left:
                Direction = Direction.down;
                break;
        }
    }
}