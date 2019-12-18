using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam.ViewModels
{
    public class LoginVM : NotificationBase
    {
        public LoginModel login { get; set; }

        public LoginVM()
        {
            login = new LoginModel();
            LoginCommand = new DelegateCommand(Auth);
        }

        public ICommand ToRegCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand ToHomeCommand { get; set; }

        public void Auth(object arg)
        {
            if (login.Auth())
            {
                ToHomeCommand.Execute(this);
            }
        }        
    }
}
