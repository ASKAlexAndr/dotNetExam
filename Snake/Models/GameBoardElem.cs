using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public abstract class GameBoardElem : NotificationBase
    {
        #region Fields

        protected double _xPosition;
        protected double _yPosition;
        protected double _width;
        protected double _height;

        #endregion

        #region Constructors
        public GameBoardElem()
        {            
            _width = Constants.BodyWidth;
            _height = Constants.BodyHeight;
        }
        #endregion

        #region Properties

        public double YPosition
        {
            get
            {
                return _yPosition;
            }
        }
        public double XPosition
        {
            get
            {
                return _xPosition;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
        }

        public double XPositionPixelsScreen
        {
            get
            {
                return _xPosition - (_width / 2);
            }
        }

        public double YPositionPixelsScreen
        {
            get
            {
                return _yPosition - (_height / 2);
            }
        }

        #endregion
    }
}
