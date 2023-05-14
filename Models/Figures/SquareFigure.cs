using System;

namespace Tetris.Models.Figures;

public class SquareFigure : Figure
{
    private const int SquareHeight = 2;
    private const int SquareWidth = 2;

    public SquareFigure() : base(SquareHeight, SquareWidth)
    {
    }

    public override void Draw(int startColumn, int startRow)
    {
        Console.SetCursorPosition(startColumn, startRow);
        Console.WriteLine("████");
        Console.SetCursorPosition(startColumn, startRow+1);
        Console.Write("████");
    }

    public override void Rotate()
    {
    }
}
