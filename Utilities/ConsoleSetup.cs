using System;
using System.Text;

namespace Tetris.Utilities;

public static class ConsoleSetup
{
    public static void SetHeight(int rows)
    {
        Console.WindowHeight = rows;
        Console.BufferHeight = rows + 3;
        Console.WindowHeight = rows + 3;
    }

    public static void SetWidth(int columns)
    {
        Console.WindowWidth = columns;
        Console.BufferWidth = columns + 20;
        Console.WindowWidth = columns + 20;
    }

    public static void SetEncoding(Encoding encoding)
    {
        Console.OutputEncoding = encoding;
    }

    public static void BackgroundColor(ConsoleColor color)
    {
        Console.BackgroundColor = color;
    }

    public static void ForegroundColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static void SetCursorPosition(int topLeftCornerRow, int topLeftCornerColumn)
    {
        Console.SetCursorPosition(topLeftCornerColumn,topLeftCornerRow);
    }

    public static void HideCursor()
    {
        Console.CursorVisible = false;
    }
}