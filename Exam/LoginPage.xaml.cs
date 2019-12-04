using DBLib;
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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ToHomePage()
        {
            Uri uri = new Uri("HomePage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void Menu_login_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = loginField.Text;
                string password = passwordField.Password;
                User user = UsersContext.searchByLogin(login);
                if (user == null)
                {
                    throw new Exception("Пользователь не найден");
                }
                if (password != user.password)
                {
                    throw new Exception("Пароль не верен");
                }
                Globals.player = new Player(user);
                ToHomePage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
