using System;
using Tetris.IO.Contracts;

namespace Tetris.IO;

public class Reader : IReader
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}