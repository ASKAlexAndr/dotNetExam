using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam.ViewModels
{
    class HomeVM : NotificationBase
    {
        public int Score { get
            {
                return Player.GetRecord();
            } 
        }
        public HomeVM()
        {
            
        }
        public ICommand LogOutCommand { get; set; }
        public ICommand ToStatisticCommand { get; set; }
        public ICommand PlayCommand { get; set; }


    }
}
