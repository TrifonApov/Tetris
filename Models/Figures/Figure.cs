using Tetris.Enums;
using Tetris.Models.Contracts;

namespace Tetris.Models.Figures;

public abstract class Figure : IDraw, IRotate
{
    protected Figure()
    {
        Direction = Direction.up;
    }

    public Direction Direction { get; protected set; }

    public abstract void Draw(int startColumn, int startRow);
    public abstract void Rotate();
}
