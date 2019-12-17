using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    class Constants
    {
        public const double DefaultBoardWidth = 800;
        public const double DefaultBoardHeight = 600; 
        public const double DefaultGameStepMilliseconds = 20;
        public const double DefaultXposition = 50;
        public const double DefaultYposition = 50;
        public const double BodyWidth = 20;
        public const double BodyHeight = 20;

        public const double DirectionUpDegrees = 0;
        public const double DirectionRightDegrees = 90;
        public const double DirectionDownDegrees = 180;
        public const double DirectionLeftDegrees = 270;
        public const Direction DefaultDirection = Direction.Right;
        public const double StepSize = 20;
    }
}
