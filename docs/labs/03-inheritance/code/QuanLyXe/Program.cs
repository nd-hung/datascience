// Chương trình chính
namespace QuanLyXe
{
    class Program
    {
        public static void Main()
        {
            // Tạo 1 đối tượng Xe
            Xe x1 = new Xe("79A-1232", 2020);
            x1.Xuat();
            // Tạo 1 đối tượng XeCon
            XeCon xc1 = new XeCon("78C-12345", 2021, 5);
            xc1.Xuat();
        }
    }
}