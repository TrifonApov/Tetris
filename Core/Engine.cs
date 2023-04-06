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

namespace Tetris.Core
{
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

            int row = 1;
            int column = 1;

            TFigure tFigure = new TFigure();
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo;
                do
                {
                    if (Console.KeyAvailable)
                    {
                        consoleKeyInfo = Console.ReadKey();


                        if (Console.KeyAvailable)
                        {

                            if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                            {
                                column--;
                            }
                            else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                            {
                                column++;
                            }
                            else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                            {
                                row++;
                            }
                        }
                    }

                    Console.SetCursorPosition(0, 0);
                    writer.Write(field.DrawField());

                    tFigure.RotateFigure();
                    tFigure.Draw(column, row);
                    Thread.Sleep(500);

                } while (!Console.KeyAvailable);
            }
        }
    }
}
