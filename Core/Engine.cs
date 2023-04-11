using System;
using System.Text;
using System.Threading;
using Tetris.Core.Contracts;
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

    public Engine()
    {
        this.reader = new Reader();
        this.writer = new Writer();
        this.controller = new Controller();
    }

    public void Run()
    {
        ConsoleSetup.SetHeight(20);
        ConsoleSetup.SetWidth(20);
        ConsoleSetup.BackgroundColor(ConsoleColor.Yellow);
        ConsoleSetup.ForegroundColor(ConsoleColor.DarkRed);
        ConsoleSetup.SetEncoding(Encoding.Unicode);
        ConsoleSetup.HideCursor();
        ConsoleSetup.Clear();

        GameField field = new GameField(20, 10);

        int row = 2;
        int column = 2;

        Figure tFigure = new TFigure();
        Figure gFigure = new GFigure();
        Figure lFigure = new LFigure();
        Figure squareFigure = new SquareFigure();
        Figure lineFigure = new LineFigure();


        while (true)
        {
            do
            {
                if (Console.KeyAvailable)
                {
                    var consoleKeyInfo = Console.ReadKey();


                    if (Console.KeyAvailable)
                    {

                        if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            column-=2;
                        }
                        else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                        {
                            column+=2;
                        }
                        else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                        {
                            row++;
                        }
                    }
                }

                Console.SetCursorPosition(0, 0);
                writer.Write(field.DrawField());

                tFigure.Rotate();
                tFigure.Draw(2, 2);
                
                gFigure.Rotate();
                gFigure.Draw(2, 6);

                lFigure.Rotate();
                lFigure.Draw(10, 6);

                squareFigure.Draw(10,2);

                lineFigure.Rotate();
                lineFigure.Draw(2,10);

                Thread.Sleep(500);

            } while (!Console.KeyAvailable);
        }
    }
}