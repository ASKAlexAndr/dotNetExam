using DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public static class Player
    {
        public static User user;

        public static void UpdateUserData()
        {
            user = UsersContext.searchByLogin(user.login);
        }

        public static int GetRecord()
        {
            try
            {
                return UsersContext.getUserScore(user.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
