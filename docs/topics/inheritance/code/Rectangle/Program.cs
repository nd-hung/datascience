/*
Minh họa kỹ thuật thừa kế
Xây dựng lớp hình chữ nhật (Rectangle).
Xây dựng lớp hình vuông (Square).
*/

// Cài đặt lớp Rectangle
public class Rectangle
{
    protected double Width { get; set; }
    protected double Height { get; set; }
    // Hàm thiết lập 
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }
    // Hàm tính diện tích hình chữ nhật
    public double Area()
    {
        return Width * Height;
    }
}

// Xây dựng lớp Square kế thừa lớp Rectangle
public class Square : Rectangle
{
    // Hàm thiết lập
    public Square(double w = 0) : base(w, w) { }
}

// Chương trình chính
class Program
{
    static void Main()
    {
        // Tạo đối tượng hình chữ nhật
        Rectangle r1 = new Rectangle(3, 7);
        // In diện tích hình chữ nhật
        Console.WriteLine("Dien tich hinh chu nhat = {0}", r1.Area());

        // Tạo đối tượng hình vuông
        Square s1 = new Square(5);
        // In diện tích hình vuông
        double area = s1.Area();
        Console.WriteLine("Dien tich hinh vuong = {0}", area);
    }
}
