using System;
using System.Text;
using System.Threading;
using Tetris.Core.Contracts;
using Tetris.IO;
using Tetris.IO.Contracts;
using Tetris.Models;
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

            writer.Write(field.DrawField());
            int count = 0;

            int row = 1;
            int column = 2;
            ConsoleSetup.SetCursorPosition(row, column);

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        ConsoleSetup.SetCursorPosition(row, column);
                        writer.Write(Char.ToString('\u25A1'));
                        ConsoleSetup.SetCursorPosition(--row, column);
                        break;
                    case ConsoleKey.DownArrow:
                        ConsoleSetup.SetCursorPosition(row, column);
                        writer.Write(Char.ToString('\u25A1'));
                        ConsoleSetup.SetCursorPosition(++row, column);
                        break;
                    case ConsoleKey.LeftArrow:
                        ConsoleSetup.SetCursorPosition(row, column);
                        writer.Write(Char.ToString('\u25A1'));
                        ConsoleSetup.SetCursorPosition(row, --column);
                        break;
                    case ConsoleKey.RightArrow:
                        ConsoleSetup.SetCursorPosition(row, column);
                        writer.Write(Char.ToString('\u25A1'));
                        ConsoleSetup.SetCursorPosition(row, ++column);
                        break;
                    default: continue;
                }
                writer.Write(Char.ToString('■'));
            }
        }
    }
}
