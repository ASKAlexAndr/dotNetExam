using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class SnakeBody : SnakePart
    {
        public SnakeBody(Snake snake)
        {

            SnakePart lastPart;
            try
            {
                lastPart = snake.Body.Last();
            }
            catch
            {
                lastPart = snake.Head;
            }

            if (lastPart.DirectionOfTravel == Direction.Up)
            {
                _xPosition = lastPart.XPosition;
                _yPosition = lastPart.YPosition + _height;
                _directionOfTravel = Direction.Up;
            }
            else if (lastPart.DirectionOfTravel == Direction.Left)
            {
                _xPosition = lastPart.XPosition + _width;
                _yPosition = lastPart.YPosition;
                _directionOfTravel = Direction.Left;
            }
            else if (lastPart.DirectionOfTravel == Direction.Down)
            {
                _xPosition = lastPart.XPosition;
                _yPosition = lastPart.YPosition - _height;
                _directionOfTravel = Direction.Down;
            }
            else if (lastPart.DirectionOfTravel == Direction.Right)
            {
                _xPosition = lastPart.XPosition - _width;
                _yPosition = lastPart.YPosition;
                _directionOfTravel = Direction.Right;
            }
        }
    }
}
