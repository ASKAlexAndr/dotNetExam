using Exam.Models;
using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam.ViewModels
{
    class NavigationVM : NotificationBase
    {
        public LoginModel login { get; set; }

        public LoginVM loginVM { get; private set; }
        public RegistrationVM registrationVM { get; private set; }

        public HomeVM homeVM { get; private set; }
        public StatisticVM statisticVM { get; private set; }

        private object _currentView { get; set; }

        public object CurrentView
        {
            get
            {
                return _currentView; 
            }            
            set 
            { 
                _currentView = value; 
                RaisePropertyChanged("CurrentView");
            }
        }
        public NavigationVM()
        {
            loginVM = new LoginVM
            {
                ToHomeCommand = new DelegateCommand(OpenHome),
                ToRegCommand = new DelegateCommand(OpenRegister)
            };

            registrationVM = new RegistrationVM
            {
                ToHomeCommand = new DelegateCommand(OpenHome),
                ToLoginCommand = new DelegateCommand(OpenLogin)
            };

            homeVM = new HomeVM
            {
                LogOutCommand = new DelegateCommand(OpenLogin),
                ToStatisticCommand = new DelegateCommand(OpenStatistic),
                PlayCommand = new DelegateCommand(OpenGame)
            };

            statisticVM = new StatisticVM
            {
                ToHomeCommand = new DelegateCommand(OpenHome)
            };

            OpenLogin(this);
        }

        public void OpenLogin(object obj)
        {
            CurrentView = loginVM;
        }
        public void OpenRegister(object obj)
        {
            CurrentView =  registrationVM;
        }

        public void OpenHome(object obj)
        {
            CurrentView = homeVM;
        }
        public void OpenGame(object obj)
        {
            SnakeView game = new SnakeView(Player.user.Id);
            CurrentView = game;
            game.ExitGame = new DelegateCommand(OpenHome);
        }
        public void OpenStatistic(object obj)
        {
            CurrentView = statisticVM;
        }

    }
}
