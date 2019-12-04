using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Game.Models
{
    class Constants
    {
        public const double DefaultBoardWidth = 780;
        public const double DefaultBoardHeight = 400;
        public const double DefaultGameStepMilliseconds = 250;
        public const double DefaultXposition = 50;
        public const double DefaultYposition = 50;
        public const double BodyWidth = 15;
        public const double BodyHeight = 15;

        public const double DirectionUpDegrees = 0;
        public const double DirectionRightDegrees = 90;
        public const double DirectionDownDegrees = 180;
        public const double DirectionLeftDegrees = 270;
        public const Direction DefaultDirection = Direction.Right;
        public const double StepSize =15;
    }
}
