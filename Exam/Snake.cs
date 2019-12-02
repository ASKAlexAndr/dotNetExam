using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exam
{
    public class Snake
    {
        private int Length = 5;
        private int Speed = 400;
        private int SpeedLimit = 100;
        private int bodySize = 25;
        private List<SnakeBody> Body = new List<SnakeBody>();
        public Snake() { }
    }

    class SnakeBody
    {
        public UIElement UiElement { get; set; }
        public Point Position { get; set; }
        public bool IsHead { get; set; }
    }
}
