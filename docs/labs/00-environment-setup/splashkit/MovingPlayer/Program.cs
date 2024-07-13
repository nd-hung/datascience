using System;
using SplashKitSDK;


public class Program
{
    public static void Main()
    {
        Window gameWindow; 
        Player player1;

        const int WIDTH = 500;
        const int HEIGHT = 300;
                
        // create new game window:
        gameWindow = new Window("Moving Object", WIDTH, HEIGHT);

        // create new player within the game window
        player1 = new Player(gameWindow);

        // loop
        do {
            SplashKit.ProcessEvents();
            player1.HandleInput();
            player1.StayOnWindow(gameWindow);
            gameWindow.Clear(Color.White);
            player1.Draw(gameWindow);
            gameWindow.Refresh(50);
        } while (!gameWindow.CloseRequested && !player1.Quit);
    }
}
