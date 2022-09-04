using System;
using SplashKitSDK;
using System.Collections.Generic;
using _3._2P;

namespace _3._2P
{
    public class Shape
    {
        private Color _color;
        private bool _selected;
        private float x, y;
        private int width, height;

        public Shape()
        {
            _color = Color.Red;
            x = 0;
            y = 0;
            width = 50;
            height = 50;
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
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, x = -2, y = -2, width = 4, height = 4);
        }
        public void Draw() 
        {
            if (_selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, x, y, width, height);

        }
    }
}
