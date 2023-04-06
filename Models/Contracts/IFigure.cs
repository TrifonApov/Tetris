using Tetris.Enums;

namespace Tetris.Models.Contracts
{
    public interface IFigure
    {
        public int Height { get; }

        public int Width { get; }

        //public abstract void RotateFigure(Direction Direction);

        //public void Draw(int startRow, int startColumn);
    }
}