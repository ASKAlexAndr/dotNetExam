using Exam.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Exam
{
    public class Snake
    {
        private int Length = 5;
        private int Speed = 400;
        private int SpeedLimit = 100;
        private int bodySize = 25;

        private volatile bool _updatingSnake;
        //private volatile bool isAlive;
        //private List<SnakeBody> Body = new List<SnakeBody>();
        public Snake() {
            Head = new SnakeHead(Constants.DefaultXposition, Constants.DefaultYposition, Constants.DefaultDirection);
            _updatingSnake = false;
        }

        public SnakeHead Head { get; }

        public void UpdateStatus()
        {
            while (_updatingSnake)
            {
                Thread.Sleep(50);
            }

            _updatingSnake = true;
            Head.UpdatePosition();

            //Direction previousDirection;
            //Direction nextDirection = Head.DirectionOfTravel;

            _updatingSnake = false;
        }

        public void SetSnakeDirection(Direction direction)
        {
            while (_updatingSnake)
            {
                Thread.Sleep(50);
            }

            _updatingSnake = true;
            Head.DirectionOfTravel = direction;
            _updatingSnake = false;
        }
    }

    public class SnakeHead : SnakePart
    {
      

        public SnakeHead(double initialXPosition, double initialYPosition, Direction direction):base(direction)
        {
            xPos = initialXPosition;
            yPos = initialYPosition;
            //_width = Constants.BodyWidth;
            //_height = Constants.BodyHeight;
        }
    }

    public class SnakePart : NotificationBase
    {
        protected Direction _directionOfTravel;
        public double xPos { get; set; }
        public double yPos { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public SnakePart(Direction direction)
        {
            _directionOfTravel = direction;
            width = Constants.BodyWidth;
            height = Constants.BodyHeight;
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
                yPos = yPos - Constants.StepSize;
                RaisePropertyChanged("yPos");
            }
            else if (_directionOfTravel == Direction.Right)
            {
                xPos = xPos + Constants.StepSize;
                RaisePropertyChanged("xPos");
            }
            else if (_directionOfTravel == Direction.Down)
            {
                yPos = yPos + Constants.StepSize;
                RaisePropertyChanged("yPos");
            }
            else if (_directionOfTravel == Direction.Left)
            {
                xPos = xPos - Constants.StepSize;
                RaisePropertyChanged("xPos");
            }
        }


    }
}
