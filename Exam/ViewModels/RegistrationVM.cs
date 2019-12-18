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
        public RegistrationModel reg { get; set; }

        public RegistrationVM()
        {
            reg = new RegistrationModel();
            RegistrateCommand = new DelegateCommand(Registrate);
        }

        public ICommand ToLoginCommand { get; set; }
        
        public ICommand RegistrateCommand { get; set; }

        public ICommand ToHomeCommand { get; set; }

        public void Registrate(object args)
        {
            if (reg.Registate())
            {
                ToHomeCommand.Execute(this);
            }
        }
    }
}
