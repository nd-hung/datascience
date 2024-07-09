// Chương trình chính

class Program
{
    static void Main()
    {
        // Tạo phân số bằng cách gọi phương thức thiết lập
        PhanSo ps1 = new PhanSo(4,12);
        // In phân số
        ps1.Xuat();
        // Tối giản
        ps1.ToiGian();
        // In phân số sau khi tối giản
        ps1.Xuat();

        // Tạo phân số bằng cách gọi phương thức nhập
        PhanSo ps2 = new PhanSo();
        ps2.Nhap();
        // In phân số
        ps2.Xuat();
    }
}