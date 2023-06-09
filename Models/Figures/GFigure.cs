﻿using System;
using Tetris.Enums;

namespace Tetris.Models.Figures;

public class GFigure : Figure
{
    private const int GHeight = 3;
    private const int GWidth = 3;

    public GFigure() : base(GHeight, GWidth)
    {
    }

    public override void Draw(int startColumn, int startRow)
    {
        switch (this.Direction)
        {
            case Direction.up:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]████");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("[]██[]");
                break;

            case Direction.left:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("██[][]");
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
                Console.Write("[][]██");
                break;

            case Direction.down:
                Console.SetCursorPosition(startColumn, startRow);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 1);
                Console.Write("[]██[]");
                Console.SetCursorPosition(startColumn, startRow + 2);
                Console.Write("████[]");
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