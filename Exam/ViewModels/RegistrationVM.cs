using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam.ViewModels
{
    public class RegistrationVM : NotificationBase
    {
        public LoginModel login { get; set; }

        public RegistrationVM()
        {
            login = new LoginModel();
        }

        public ICommand ToLoginCommand { get; set; }
    }
}
