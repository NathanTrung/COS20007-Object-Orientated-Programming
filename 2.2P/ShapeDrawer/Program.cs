using System;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Shape myShape = new Shape();
            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myShape.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape = new Shape();
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myShape = newShape;
                }

                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = Color.Random();
                }
                myShape.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
