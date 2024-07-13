using SplashKitSDK;

// Khai báo lớp hình tròn 
public class Circle
{
    // fields 
    private double _x; // (_x,_y): tọa độ tâm trong mặt phẳng
    private double _y;
    private double _radius; 
    private Color _color;

    // properties
    public double X{
        get{return _x;}
    } 

    public double Y{
        get{return _y;}
    }
    
    public double Radius{
        get{return _radius;}
    }     
    
    public Color Color{
        get{return _color;}
    }

    /* 
        Hàm thiết lập (constructor) 
        khởi tạo đối tượng hình tròn
    */
    public Circle(double x, double y, double r)
    {
        _x = x;
        _y = y;
        _radius = r;
        _color = Color.Blue;
    }
}
