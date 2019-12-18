using Exam.Models;
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
        public ICommand LoginCommand { get; private set; }
        
        public ICommand HomeCommand { get; private set; }

        public LoginModel login { get; set; }

        public LoginVM loginVM { get; private set; }
        public RegistrationVM registrationVM { get; private set; }

        public string LoginName { get; set;  }
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
            login = new LoginModel();
            LoginName = "FFFF";
            loginVM = new LoginVM();            
            registrationVM = new RegistrationVM();

            registrationVM.ToLoginCommand = new DelegateCommand(OpenLogin);
            loginVM.ToRegCommand = new DelegateCommand(OpenRegister);
            OpenRegister(this);
        }

        public void OpenLogin(object obj)
        {
            CurrentView = loginVM;
            //CurrentView = new LoginVM();
        }
        public void OpenRegister(object obj)
        {
            CurrentView =  registrationVM;
        }

    }
}
