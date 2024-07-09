// Minh họa cơ chế đa hình

// Tạo lớp hình vẽ tổng quát (Shape)
public class Shape
{
    // Phương thức ảo tính diện tích
    public virtual double GetArea()
    {
        return 0;
    }
}

// Tạo lớp hình tròn (Circle) kế thừa lớp hình vẽ
public class Circle : Shape
{
    public double Radius;   // Thuộc tính lưu độ dài bán kính

    // Constructor
    public Circle(double r = 0)
    {
        Radius = r;
    }

    // Phương thức ghi đè (override) tính diện tích hình tròn
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Lớp hình chữ nhật (Rectangle) kế thừa lớp hình vẽ
public class Rectangle : Shape
{
    public double Width;    // Các thuộc tính lưu kích thước hình chữ nhật
    public double Height;

    // Constructor
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }

    // Phương thức ghi đè tính diện tích hình chữ nhật
    public override double GetArea()
    {
        return Width * Height;
    }
}