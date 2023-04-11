using System;
using Tetris.Enums;

namespace Tetris.Models.Figures;

public class LineFigure : Figure
{
    public override void Draw(int startColumn, int startRow)
    {
        switch (this.Direction)
        {
            case Direction.up:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]██[][]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]██[][]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]██[][]");
                Console.SetCursorPosition(startColumn, startRow + 3);
                Console.Write("[]██[][]");
                break;

            case Direction.down:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[][][][]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[][][][]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("████████");
                Console.SetCursorPosition(startColumn, startRow + 3);
                Console.Write("[][][][]");
                break;
        }
    }

    public override void Rotate()
    {
        switch (Direction)
        {
            case Direction.up:
                Direction = Direction.down;
                break;
            
            case Direction.down:
                Direction = Direction.up;
                break;
        }
    }
}