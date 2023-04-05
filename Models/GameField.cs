using Tetris.Utilities;

namespace Tetris.Models
{
    class GameField
    {
        private int height;
        private int width;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            private set
            {
                ValidateData.ValidateZeroOrNegativeDimensions(value);
                width = value;
            }
        }


    }
}