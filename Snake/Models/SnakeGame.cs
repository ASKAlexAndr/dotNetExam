using DBLib;
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
        private bool isGameOn { get; set; }
        private DispatcherTimer _gameTimer;
        private int userId;
        public int score { get; private set; }
        public Snake snake { get; private set; }
        public Food food { get; private set; }
        public GameBoard board { get; private set; }
        public bool isGameOff
        {
            get
            {
                return !isGameOn;
            }
        }
        public SnakeGame(int id)
        {
            userId = id;
            Snake.OnEatFood += EatFoodEventHandler;
            Snake.OnHitSelf += HitSelfEventHandler;
            StartGame();
        }

        private void StartGame()
        {
            score = 0;
            board = new GameBoard();
            snake = new Snake();
            food = new Food(snake.Head.XPosition, snake.Head.YPosition);

            _gameTimer = new DispatcherTimer();
            _gameStepMilliseconds = Constants.DefaultGameStepMilliseconds;
            _gameTimer.Interval = TimeSpan.FromMilliseconds(_gameStepMilliseconds);
            _gameTimer.Tick += new EventHandler(GameTimerEventHandler);
            _gameTimer.Start();
            isGameOn = true;
            RaisePropertyChanged("isGameOn");
            RaisePropertyChanged("isGameOff");

        }

        private void EatFoodEventHandler()
        {
            food.ChangePosition(snake);
            score++;
            RaisePropertyChanged("score");
        }

        private void HitSelfEventHandler()
        {
            GameOver();
        }
        private void GameOver()
        {
            if (isGameOn)
            {
                isGameOn = false;
                UsersContext.updateUserScore(score, userId);

                RaisePropertyChanged("isGameOn");
                RaisePropertyChanged("isGameOff");
            }
           
        }
        private void GameTimerEventHandler(object sender, EventArgs e)
        {
            if (isGameOn)
            {
                snake.UpdateStatus(food);
            } 
            else
            {
                _gameTimer.Stop();
            }
        }

        public void OnKeyPressedEvent(Direction direction)
        {
            snake.SetDirection(direction);
        }

    }
}
