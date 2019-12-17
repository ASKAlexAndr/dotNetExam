using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Food : GameBoardElem
    {
        private Random _randomValue;
        public Food(double snakeXPosition, double snakeYPosition)
        {
            _randomValue = new Random((int)DateTime.Now.Ticks);
            _xPosition = _randomValue.Next(10, (int)Constants.DefaultBoardWidth - 10);
            _yPosition = _randomValue.Next(10, (int)Constants.DefaultBoardHeight - 10);

        }

        public void ChangePosition(Snake snake)
        {
            //bool changed = false;
            //double xDiff;
            //double yDiff;
            _xPosition = _randomValue.Next(10, (int)Constants.DefaultBoardWidth-10);
            _yPosition = _randomValue.Next(10, (int)Constants.DefaultBoardHeight-10);
            RaisePropertyChanged("YPosition");
            RaisePropertyChanged("YPositionPixelsScreen");
            RaisePropertyChanged("XPosition");
            RaisePropertyChanged("XPositionPixelsScreen");
        }
    }
}
