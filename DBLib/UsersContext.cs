using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public static class UsersContext
    {

        private static DbConnectDataContext db = DbContext.Service;
        public static Users searchByLogin(string login)
        {
            return (from user in db.Users
                    where user.login == login
                    select user).FirstOrDefault();
        }
        public static int getUserScore(int user_id)
        {
            return (int)db.Games.Where(el => el.user_id == user_id)
                 .Select(el => el.score)
                 .AsEnumerable()
                 .DefaultIfEmpty(0)
                 .Sum();
        }
        public static void updateUserScore(int score, int user_id)
        {
            try
            {
                Games game = new Games();
                game.user_id = user_id;
                game.score = score;
                db.Games.InsertOnSubmit(game);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Users createUser(string name, string surname, string login, string password)
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
