using DBLib;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Exam.ViewModels
{
    class StatisticVM : NotificationBase
    {
        public StatisticVM()
        {

            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ICommand ToHomeCommand { get; set; }
    }
}
