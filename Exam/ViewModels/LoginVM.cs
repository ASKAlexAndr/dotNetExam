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
            ToRegCommand = new DelegateCommand(OnRegClick);
        }

        public ICommand ToRegCommand { get; private set; }

        public void OnRegClick(object arg)
        {
            ;
        }
    }
}
