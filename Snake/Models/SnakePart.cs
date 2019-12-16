using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public abstract class SnakePart : GameBoardElem
    {
        protected Direction _directionOfTravel;

        public SnakePart()
        {
        }
        public Direction DirectionOfTravel
        {
            get
            {
                return _directionOfTravel;
            }
            set
            {
                _directionOfTravel = value;
                RaisePropertyChanged("DirectionOfTravel");
                RaisePropertyChanged("DirectionOfTravelDegrees");
            }
        }

        public double DirectionOfTravelDegrees
        {
            get
            {
                double direction = 0;

                if (_directionOfTravel == Direction.Up)
                {
                    direction = Constants.DirectionUpDegrees;
                }
                else if (_directionOfTravel == Direction.Right)
                {
                    direction = Constants.DirectionRightDegrees;
                }
                else if (_directionOfTravel == Direction.Down)
                {
                    direction = Constants.DirectionDownDegrees;
                }
                else if (_directionOfTravel == Direction.Left)
                {
                    direction = Constants.DirectionLeftDegrees;
                }

                return direction;
            }
        }

        public void UpdatePosition()
        {
            if (_directionOfTravel == Direction.Up)
            {
                _yPosition = _yPosition - Constants.StepSize;
                if (_yPosition <= 0)
                {
                    _yPosition = Constants.DefaultBoardHeight - Height;
                }
                RaisePropertyChanged("YPosition");
                RaisePropertyChanged("YPositionPixelsScreen");
            }
            else if (_directionOfTravel == Direction.Right)
            {
                _xPosition = _xPosition + Constants.StepSize;
                if (_xPosition >= Constants.DefaultBoardWidth)
                {
                    _xPosition = Width / 2;
                }
                RaisePropertyChanged("XPosition");
                RaisePropertyChanged("XPositionPixelsScreen");
            }
            else if (_directionOfTravel == Direction.Down)
            {
                _yPosition = _yPosition + Constants.StepSize;
                if (_yPosition >= Constants.DefaultBoardHeight)
                {
                    _yPosition = Height / 2;
                }
                RaisePropertyChanged("YPosition");
                RaisePropertyChanged("YPositionPixelsScreen");
            }
            else if (_directionOfTravel == Direction.Left)
            {
                _xPosition = _xPosition - Constants.StepSize;
                if (_xPosition <= 0)
                {
                    _xPosition = Constants.DefaultBoardWidth - Width;
                }
                RaisePropertyChanged("XPosition");
                RaisePropertyChanged("XPositionPixelsScreen");
            }
        }
    }
}
