using Tetris.Enums;
using Tetris.Models.Contracts;

namespace Tetris.Models.Figures;

public abstract class Figure : IDraw, IRotate
{
    private int height;
    private int width;

    protected Figure(int height, int width)
    {
        Direction = Direction.up;
    }

    public Direction Direction { get; protected set; }

    public int Height => height;

    public int Width => width;

    public abstract void Draw(int startColumn, int startRow);
    public abstract void Rotate();
}
