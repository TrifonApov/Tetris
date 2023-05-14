namespace Tetris.Models.Contracts;

public interface IDraw
{
    public int Height { get; }

    public int Width { get; }

    public void Draw(int startColumn, int startRow);
}