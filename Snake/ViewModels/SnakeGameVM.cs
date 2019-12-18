using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Snake.ViewModels
{
    class SnakeGameVM : NotificationBase
    {
        public SnakeGameVM(int userId)
        {
            snakeGame = new Models.SnakeGame(userId);
            UpKeyPressedCommand = new DelegateCommand(OnUpKeyPressed);
            RightKeyPressedCommand = new DelegateCommand(OnRightKeyPressed);
            DownKeyPressedCommand = new DelegateCommand(OnDownKeyPressed);
            LeftKeyPressedCommand = new DelegateCommand(OnLeftKeyPressed);
        }
        public ICommand UpKeyPressedCommand { get; private set; }
        public ICommand DownKeyPressedCommand { get; private set; }
        public ICommand LeftKeyPressedCommand { get; private set; }
        public ICommand RightKeyPressedCommand { get; private set; }


        public ICommand ToHomeCommand { get; set; }

        public Models.SnakeGame snakeGame { get; }

        public void OnUpKeyPressed(object arg)
        {
            snakeGame.OnKeyPressedEvent(Direction.Up);
        }
        public void OnRightKeyPressed(object arg)
        {
            snakeGame.OnKeyPressedEvent(Direction.Right);
        }
        public void OnDownKeyPressed(object arg)
        {
            snakeGame.OnKeyPressedEvent(Direction.Down);
        }
        public void OnLeftKeyPressed(object arg)
        {
            snakeGame.OnKeyPressedEvent(Direction.Left);
        }
    }
}
