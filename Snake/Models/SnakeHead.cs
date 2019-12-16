using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class SnakeHead : SnakePart
    {
        public SnakeHead()
        {
            _xPosition = Constants.DefaultXposition;
            _yPosition = Constants.DefaultYposition;
        }

        public bool EatFood(Food food)
        {
            double xDiff = Math.Abs(XPositionPixelsScreen - food.XPositionPixelsScreen);
            double yDiff = Math.Abs(YPositionPixelsScreen - food.YPositionPixelsScreen);

            if (xDiff < _width && yDiff < _height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
