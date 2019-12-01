using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public class DbContext
    {
        public DbConnectDataContext db = null;
        public DbContext()
        {
            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;" +
                @"Integrated Security=True;Connect Timeout=30;" +
                @"AttachDbFilename=D:\Dev\Exam\DBLib\ExamDB.mdf;";
            this.db = new DbConnectDataContext(connectionString);
        }

        public Users searchByLogin(string login)
        {
            return (from user in db.Users
                          where user.login == login
                          select user).FirstOrDefault();            
        }
        public Users createUser(string name, string surname, string login, string password)
        {
            try
            {
                if (searchByLogin(login) != null)
                {
                    throw new Exception("Пользователь уже существует");
                }
                Users user = new Users();
                user.name = name;
                user.surname = surname;
                user.login = login;
                user.password = password;
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }         
        }
    }
}
