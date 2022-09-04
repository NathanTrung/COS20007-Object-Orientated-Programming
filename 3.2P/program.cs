using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using _3._2P;

namespace _3._2P
{
    public class program
    {
        public static void Main()
        {
            Drawing drawing = new Drawing();
            new Window("Shape Drawer", 800, 800);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape shape = new Shape();
                    shape.X = SplashKit.MouseX();
                    shape.Y = SplashKit.MouseY();
                    drawing.AddShape(shape);
   
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawing.Background = Color.Random();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton)) 
                {
                    drawing.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey)) 
                {
                    Point2D holder = SplashKit.MousePosition();
                    drawing.SelectShapesAt(holder);
                    foreach (Shape s in drawing.SelectedShapes)
                    {
                        drawing.RemoveShape(s);
                    }
                }

                drawing.Draw();
                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));
            }

        }
    }
