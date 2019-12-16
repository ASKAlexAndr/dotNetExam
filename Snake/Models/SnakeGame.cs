using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Snake.Models
{
    class SnakeGame : NotificationBase
    {
       
        private double _gameStepMilliseconds;
        private DispatcherTimer _gameTimer;
        public int score { get; private set; }
        public Snake snake { get; private set; }
        public Food food { get; private set; }
        public GameBoard board { get; private set; }
        public SnakeGame()
        {
            StartGame();
        }

        private void StartGame()
        {
            score = 0;
            board = new GameBoard();
            snake = new Snake();
            food = new Food(snake.Head.XPosition, snake.Head.YPosition);
            Snake.OnEatFood += EatFoodEventHandler;
            _gameTimer = new DispatcherTimer();
            _gameStepMilliseconds = Constants.DefaultGameStepMilliseconds;
            _gameTimer.Interval = TimeSpan.FromMilliseconds(_gameStepMilliseconds);
            _gameTimer.Tick += new EventHandler(GameTimerEventHandler);
            _gameTimer.Start();
        }

        private void EatFoodEventHandler()
        {
            food.ChangePosition(snake);
            score++;
            RaisePropertyChanged("score");

        }
        private void GameTimerEventHandler(object sender, EventArgs e)
        {
            snake.UpdateStatus(food);
        }

        public void OnKeyPressedEvent(Direction direction)
        {
            snake.SetDirection(direction);
        }
    }
}
