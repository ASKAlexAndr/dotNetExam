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
using System.Threading;
using System.Globalization;
using DBLib;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {

        DbContext db = new DbContext();
        public Login()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            InitializeComponent();
        }

        private void Reg_link_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            Close();
            registration.Show();
        }

        private void ToMain()
        {
            Main main = new Main();
            Close();
            main.Show();
        }
        private void Menu_login_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = loginField.Text;
                string password = passwordField.Password;
                Users user = db.searchByLogin(login);
                if(user == null)
                {
                    throw new Exception("Пользователь не найден");
                }
                if (password != user.password)
                {
                    throw new Exception("Пароль не верен");
                }
                ToMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
