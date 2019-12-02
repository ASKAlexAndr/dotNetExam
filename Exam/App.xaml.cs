using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public static class Globals
    {
        private static Player _player = null;
        public static Player player { get => _player; set => _player = value; }
    }
    public partial class App : Application
    {
    }
}
