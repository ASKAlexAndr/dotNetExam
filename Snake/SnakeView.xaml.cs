using Snake.Models;
using Snake.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snake
{
    /// <summary>
    /// Логика взаимодействия для SnakeView.xaml
    /// </summary>
    public partial class SnakeView : UserControl
    {
        public SnakeView(int userId)
        {
            InitializeComponent();
            SnakeGameVM viewModel = new SnakeGameVM(userId);
            viewModel.ToHomeCommand = new DelegateCommand(exit);
            DataContext = viewModel;
        }
        public ICommand ExitGame { get; set; }
        private void exit(object arg)
        {
            ExitGame.Execute(this);
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Focus();
        }
    }
}
