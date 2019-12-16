using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class GameBoard : GameBoardElem
    {
        public GameBoard()
        {
            _width = Constants.DefaultBoardWidth;
            _height = Constants.DefaultBoardHeight;
        }
    }
}
