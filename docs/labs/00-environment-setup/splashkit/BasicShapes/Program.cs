using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window shapeWindow; 

        const int WIDTH = 800;
        const int HEIGHT = 600;
                
        // create new window
        shapeWindow = new Window("Basic Shapes", WIDTH, HEIGHT);
        shapeWindow.Clear(Color.White);
        
        Circle c = new Circle(400, 200, 100);
        shapeWindow.FillCircle(c.Color, c.X, c.Y, c.Radius);
        SplashKit.RefreshScreen();
        SplashKit.Delay(10000);
    }
}
