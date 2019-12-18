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
        }

        public ICommand ToRegCommand { get; set; }
        
    }
}
