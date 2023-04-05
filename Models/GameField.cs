using System.Text;
using Tetris.Utilities;

namespace Tetris.Models
{
    class GameField
    {
        private const char FieldBackgroundSymbol = '\u25A1';
        private int height;
        private int width;
        

        public GameField(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get => height;
            private set
            {
                ValidateData.ValidateZeroOrNegativeDimensions(value);
                height = value;
            }
        }

        public int Width
        {
            get => width;
            private set
            {
                ValidateData.ValidateZeroOrNegativeDimensions(value);
                width = value;
            }
        }

        public string DrawField()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('_', width + 2));
            for (int i = 0; i < height; i++)
            {
                sb.AppendLine($"|{new string(FieldBackgroundSymbol, width)}|");
            }
            sb.AppendLine(new string('̅', width + 2));

            return sb.ToString().Trim();
        }
    }
}