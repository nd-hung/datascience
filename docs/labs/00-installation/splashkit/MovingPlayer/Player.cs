using SplashKitSDK;
public class Player
{
    private Bitmap _PlayerBitmap;

    // add the auto properties for X and Y
    public double X {get; private set;}
    public double Y {get; private set;}
    public bool Quit {get; private set;}

    // add a read-only Width property
    public int Width
    {
        get {return _PlayerBitmap.Width;}
    }

    public int Height
    {
        get {return _PlayerBitmap.Height;}
    }

    // add Player constructor
    public Player(Window gameWindow)
    {
        _PlayerBitmap = new Bitmap("Player", "resources/images/Player.png");
        // set the position ot the player to the center of the window:
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Height - Height) / 2;
        Quit = false;
    }

    // add the Draw method that draws the player bitmap ont the current window
    public void Draw(Window w)
    {
        w.DrawBitmap(_PlayerBitmap, X, Y);
    }

    // HandleInput method
    public void HandleInput()
    {
        const int SPEED = 5;
        if (SplashKit.KeyDown(KeyCode.UpKey))
        {
            Y -= SPEED;
        }
        
        if (SplashKit.KeyDown(KeyCode.DownKey))
        {
            Y += SPEED;
        }
        
        if (SplashKit.KeyDown(KeyCode.LeftKey))
        {
            X -= SPEED;
        }
        
        if (SplashKit.KeyDown(KeyCode.RightKey))
        {
            X += SPEED;
        }

        if (SplashKit.KeyTyped(KeyCode.EscapeKey))
        {
            Quit=true;
        }
    }

    // add method to keep player stayed on window
    public void StayOnWindow(Window l)
    {
        const int GAP = 10;
       
        if (Y < GAP)
        {
            Y = GAP;
        }

        if (Y > l.Height - GAP - _PlayerBitmap.Height)
        {
            Y = l.Height - GAP - _PlayerBitmap.Height;
        }

        if (X < GAP)
        {
            X = GAP;
        }

        if (X > l.Width - GAP - _PlayerBitmap.Width)
        {
            X = l.Width - GAP - _PlayerBitmap.Width;
        }
    } // end of StayOnWindow method
} // end of Player class

