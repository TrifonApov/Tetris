using System;
using Tetris.Utilities.Messages;

namespace Tetris.Utilities
{
    static class ValidateData
    {
        public static void ValidateZeroOrNegativeDimensions(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessages.ZeroOrNegativeDimension);
            }
        }
    }
}