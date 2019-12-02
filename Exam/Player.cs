using DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Player
    {
        public string name;
        public string surname;
        public int id;
        public Player(Users user)
        {
            this.name = user.name;
            this.surname = user.surname;
            this.id = user.Id;
        }
        public int Score
        {
            get
            {
                return UsersContext.getUserScore(this.id);
            }
        }
        public void updateScore(int value)
        {
            UsersContext.updateUserScore(value, this.id);
            
        }
    }
}
