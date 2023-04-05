using Tetris.Core.Contracts;
using Tetris.IO;
using Tetris.IO.Contracts;

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
        }
    }
}
