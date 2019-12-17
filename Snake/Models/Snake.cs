using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Snake : NotificationBase
    {
        private ObservableCollection<SnakeBody> _body;

        public delegate void EatFood();
        public delegate void HitSelf();

        public static event HitSelf OnHitSelf;
        public static event EatFood OnEatFood;

        public Snake()
        {
            Head = new SnakeHead();
            _body = new ObservableCollection<SnakeBody>();
            
           
        }
        public void UpdateStatus(Food food)
        {
            Head.UpdatePosition();

            Direction prevDirection;
            Direction nextDirection = Head.DirectionOfTravel;
            foreach (SnakeBody body in _body)
            {
                body.UpdatePosition();
                prevDirection = body.DirectionOfTravel;
                body.DirectionOfTravel = nextDirection;
                nextDirection = prevDirection;
            }
            if (Head.EatFood(food))
            {
                SnakeBody part = new SnakeBody(this);
                _body.Add(part);
                OnEatFood?.Invoke();
            }
            if (Head.HitSelf(this))
            {
                OnHitSelf?.Invoke();
            }

        }
        public void SetDirection(Direction direction)
        {
            Head.DirectionOfTravel = direction;

        }

        public SnakeHead Head { get; }
        public ObservableCollection<SnakeBody> Body
        {
            get
            {
                if (_body == null)
                {
                    _body = new ObservableCollection<SnakeBody>();
                }

                return _body;
            }
        }
    }
}
