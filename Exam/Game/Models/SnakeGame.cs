using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Exam.Game.Models
{
    class SnakeGame
    {
        public double boardWidth { get; set; }
        public double boardHeight { get; set; }
        private double _gameStepMilliseconds;
        private DispatcherTimer _gameTimer;
        //private int _gameSpeed;
        public int score { get; private set; }

        public Snake snake { get; private set; }

        public SnakeGame()
        {
            boardWidth = Constants.DefaultBoardHeight;
            boardHeight = Constants.DefaultBoardWidth;

            StartGame();
        }

     
        private void StartGame()
        {
            snake = new Snake();
            _gameTimer = new DispatcherTimer();
            _gameStepMilliseconds = Constants.DefaultGameStepMilliseconds;
            _gameTimer.Interval = TimeSpan.FromMilliseconds(_gameStepMilliseconds);
            _gameTimer.Tick += new EventHandler(GameTimerEventHandler);
            _gameTimer.Start();
        }

        private void GameTimerEventHandler(object sender, EventArgs e)
        {
            snake.UpdateStatus();
        }

        public void OnKeyPressedEvent(Direction direction)
        {
            snake.SetSnakeDirection(direction);
        }
    }
}
