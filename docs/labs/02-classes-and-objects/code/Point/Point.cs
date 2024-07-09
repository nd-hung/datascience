// Cài đặt lớp Point
public class Point
{
    // Khai báo thuộc tính (X, Y) là tọa độ điểm trong mặt phẳng
    public double X { get; set; }
    public double Y { get; set; }

    // Hàm thiết lập
    public Point(double x = 0, double y = 0)
    {
        X = x; Y = y;
    }

    // Phương thức nhập tọa độ điểm
    public void Nhap()
    {
        Console.Write("Nhap hoanh do X: ");
        X = double.Parse(Console.ReadLine());
        Console.Write("Nhap tung do do Y: ");
        Y = double.Parse(Console.ReadLine());
    }

    // Phương thức in tọa độ điểm
    public void Xuat()
    {
        Console.WriteLine("({0},{1})", X, Y);
    }

    // Phương thức di chuyển điểm 
    // dx, dy là độ dịch chuyển theo chiều ngang và dọc
    public void Move(double dx = 0, double dy = 0)
    {
        X += dx;
        Y += dy;
    }

    // Phương thức tính khoảng cách đến một điểm khác
    // Áp dụng công thức Euclide
    public double Distance(Point p)
    {
        return Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
    }  
} // End of class Point