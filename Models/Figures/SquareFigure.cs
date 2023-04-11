using System;

namespace Tetris.Models.Figures;

public class SquareFigure : Figure
{
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
