// Chương trình chính

class Program
{
    public static void Main()
    {
        // Tạo 1 đối tượng nhân viên tổng quát thuộc loại NVVP
        NhanVien nv1 = new NVVP("VP001", "Pham Phuong Thao", 20);
        // Tạo 1 đối tượng nhân viên tổng quát thuộc loại NVSX
        NhanVien nv2 = new NVSX("SX001", "Tran Van Hung", 50);
        // Tính lương nv 1
        Console.WriteLine("Luong cua NV1 la {0}", nv1.TinhLuong());
        // Tính lương nv 2
        Console.WriteLine("Luong cua NV2 la {0}", nv2.TinhLuong());
    }
}