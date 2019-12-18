using DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exam.Models
{
    public class LoginModel
    {
        public string LoginName { get; set; }
        public string Password { get; set; }


        public bool Auth()
        {
            try
            {
                User user = UsersContext.searchByLogin(LoginName);
                if (user == null)
                {
                    throw new Exception("Пользователь не найден");
                }
                if (Password != user.password)
                {
                    throw new Exception("Пароль не верен");
                }
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
