// Minh họa nạp chồng phương thức (method overloading)

// Tạo lớp tĩnh chứa các hàm cùng tên tính tổng 
static class MyMath
{
    // Hàm tính tổng 2 số nguyên
    public static int Sum(int x, int y)
    { return x + y; }
    // Hàm tính tổng 3 số nguyên
    public static int Sum(int x, int y, int z)
    { return x + y + z; }
    // Hàm tính tổng 2 số thực
    public static double Sum(double x, double y) 
    {  return x + y; }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(MyMath.Sum(1, 2));
        Console.WriteLine(MyMath.Sum(1, 2, 3));
        Console.WriteLine(MyMath.Sum(2.34, 3.56 ));
    }
}