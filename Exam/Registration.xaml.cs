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
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        DbContext db = new DbContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void Login_link_Click(object sender, RoutedEventArgs e)
        {
            toLogin();
        }

        private void toLogin()
        {
            Login login = new Login();
            Close();
            login.Show();
        }
        private void Menu_login_btn_Click(object sender, RoutedEventArgs e)
        {
            string name = nameField.Text;
            string surname = surnameField.Text;
            string login = loginField.Text;
            string password = passwordField.Password;
            if (name.Length == 0 || surname.Length == 0 || login.Length == 0 || password.Length == 0)
            {
                throw new Exception("Пожалуйста заполните все поля!");
            }
            try
            {
                Users u = db.createUser(name, surname, login, password);
                toLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
