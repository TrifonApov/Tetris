using System;
using Tetris.Enums;

namespace Tetris.Models.Figures;

public class SFigure : Figure
{
    private const int SHeight = 3;
    private const int SWidth = 3;

    public SFigure() : base(SHeight, SWidth)
    {
    }

    public override void Draw(int startColumn, int startRow)
    {
        switch (Direction)
        {
            case Direction.up:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[][][]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("████");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("████");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[]");

                break;

            case Direction.down:
                Console.SetCursorPosition(startColumn, startRow);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("██");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[][]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("████");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("██");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[]");
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