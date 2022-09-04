using SplashKitSDK;
using System;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;
        public Shape()
        {
            _color = Color.Green;
            _x = 0; 
            _y = 0;
            _height = 100;
            _width = 100;
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public bool IsAt(Point2D pt)
        {
            bool pointInRange = false;
            double yMax = _y + _height; // Coordinate of the shape cannot exceed window of the screen
            double xMax = _x + _width;
            if ((pt.X > _x) && (pt.X < xMax))
            {
                if ((pt.Y > _y) && (pt.Y < yMax))
                {
                    pointInRange = true;
                }
            }
            return pointInRange;
        }
    }
}
