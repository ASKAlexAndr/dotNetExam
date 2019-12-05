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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            this.DataContext = Globals.player;
        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("StatisticPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("LoginPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
            Globals.player = null;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            GameWindow game = new GameWindow();
            game.Show();
            Globals.player.updateScore(5);
            
            //Uri uri = new Uri("GamePage.xaml", UriKind.Relative);
            //this.NavigationService.Navigate(uri);
        }
    }
}
