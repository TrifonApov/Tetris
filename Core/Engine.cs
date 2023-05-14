using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Tetris.Core.Contracts;
using Tetris.Enums;
using Tetris.IO;
using Tetris.IO.Contracts;
using Tetris.Models;
using Tetris.Models.Contracts;
using Tetris.Models.Figures;
using Tetris.Utilities;

namespace Tetris.Core;

public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;
    private IController controller;
    private List<Figure> figures;
    private Random random;

    public Engine()
    {
        this.reader = new Reader();
        this.writer = new Writer();
        this.controller = new Controller();
        figures = new()
        {
            new TFigure(), new GFigure(), new LFigure(), new SquareFigure(), new LineFigure(), new ZFigure(), new SFigure()
        };
        random = new Random();
    }

    public void Run()
    {
        SetUpConsole();

        GameField field = new GameField(20, 11);
        Figure figure = figures[6];

        //Figure figure = figures[random.Next(figures.Count)];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(field.DrawField());
            int x = 1;
            int y = 10;
            figure.Draw(y, x);

            while(true)
            {
                Console.Clear();
                Console.WriteLine(field.DrawField());
                figure.Draw(y, x);

                if (Collision(figure, field))
                {
                    continue;
                }
                
            }
            Thread.Sleep(20);
        }
    }

    private static void SetUpConsole()
    {
        ConsoleSetup.SetHeight(20);
        ConsoleSetup.SetWidth(20);
        ConsoleSetup.BackgroundColor(ConsoleColor.Yellow);
        ConsoleSetup.ForegroundColor(ConsoleColor.DarkRed);
        ConsoleSetup.SetEncoding(Encoding.Unicode);
        ConsoleSetup.HideCursor();
        ConsoleSetup.Clear();
    }

    private void DrawField(GameField field)
    {
        Console.SetCursorPosition(0, 0);
        writer.Write(field.DrawField());
    }
}