using Tetris.Core;
using Tetris.Core.Contracts;

namespace Tetris;

internal class StartUp
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}