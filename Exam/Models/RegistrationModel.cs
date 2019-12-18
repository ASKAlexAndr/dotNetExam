using DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exam.Models
{
    public class RegistrationModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationModel()
        {
            Login = "";
            Password = "";
            Name = "";
            Surname = "";
        }
        public bool Registate()
        {
           
            try
            {

                if (Login.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0)
                {
                    throw new Exception("Пожалуйста заполните все поля!");
                }
                User user = UsersContext.createUser(Name, Surname, Login, Password);
                Player.user = user;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
