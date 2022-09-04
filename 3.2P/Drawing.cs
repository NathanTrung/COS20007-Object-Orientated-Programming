using System;
using SplashKitSDK;
using System.Collections.Generic;
using _3._2P;

namespace _3._2P {
public class Drawing
{
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this (Color.White)
        {

        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;   
            }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            Shape single = new Shape();
            foreach(Shape s in _shapes)
            {
                if (pt.X == s.X && pt.Y == s.Y)
                {
                    s.Selected = true;
                } else
                {
                    s.Selected = false;
                }
            }
        }
        public List<Shape> SelectedShapes
        {
            get {
                List<Shape> result = new List<Shape>();
                foreach(Shape s in _shapes)
                {
                    if(s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }


}
}

