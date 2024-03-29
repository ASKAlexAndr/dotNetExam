﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public static class UsersContext
    {

        private static DbConnectDataContext db = DbContext.Service;
        public static User searchByLogin(string login)
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
                 .Max();
        }
        public static void updateUserScore(int score, int user_id)
        {
            try
            {
                Game game = new Game
                {
                    user_id = user_id,
                    score = score
                };
                db.Games.InsertOnSubmit(game);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static User createUser(string name, string surname, string login, string password)
        {
            try
            {
                if (searchByLogin(login) != null)
                {
                    throw new Exception("Пользователь уже существует");
                }
                User user = new User
                {
                    name = name,
                    surname = surname,
                    login = login,
                    password = password
                };
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
