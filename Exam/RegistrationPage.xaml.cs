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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        DbContext db = new DbContext();
        public RegistrationPage()
        {
            InitializeComponent();
        }
        
        private void toLoginPage()
        {
            Uri uri = new Uri("LoginPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
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
                
                toLoginPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
