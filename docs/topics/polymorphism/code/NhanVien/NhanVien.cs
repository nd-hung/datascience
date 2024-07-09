// Minh họa cơ chế đa hình (động)

// Tạo lớp Nhân viên tổng quát
public class NhanVien
{
    public string MaNV{get; set;}
    public string HoTen{get; set;}
    public static double LCB=15000000; // Mức lương cơ bản

    // Hàm thiết lập
    public NhanVien(string ms="", string ht="")
    {
        MaNV = ms;
        HoTen = ht;
    }

    // Phương thức nhập thông tin NV
    public void Nhap()
    {
        Console.Write("Nhap ma NV: ");
        MaNV = Console.ReadLine();
        Console.Write("Ho ten NV: ");
        HoTen = Console.ReadLine();
    }
    // Tạo phương thức tính lương ảo (virtual)
    public virtual double TinhLuong()
    {
        return 0;
    }
}

// Tạo lớp Nhân viên văn phòng kế thừa lớp Nhân viên
class NVVP:NhanVien
{
    public int SoNgayCong;

    // Phương thức thiết lập
    public NVVP(string ms="", string ht="", int nc=0):base(ms, ht)
    {
        SoNgayCong = nc;
    }

    // Phương thức in thông tin
    public void Print()
    {
        Console.WriteLine("{0}\t{1}\t{2}", MaNV, HoTen, SoNgayCong);
    }

    // Cài đặt phương thức tính lương (ghi đè override)
    public override double TinhLuong()
    {
        // Gỉa sử công thức tính lương cho NVVP = Lương CB * số ngày công / 5;
        return LCB * SoNgayCong / 5;
    }
}

// Tạo lớp Nhân viên sản xuất kế thừa lớp Nhân viên
public class NVSX:NhanVien
{
    public int SoSP;
    public NVSX(string ms="", string ht="", int sosp=0):base(ms, ht)
    {
        SoSP = sosp;
    }

    // Phương thức in thông tin
    public void Print()
    {
        Console.WriteLine("{0}\t{1}\t{2}", MaNV, HoTen, SoSP);
    }

    // Cài đặt phương thức tính lương (ghi đè override)
    public override double TinhLuong()
    {
        // Gỉa sử công thức tính lương cho NVSX = Lương CB * số SP / 8;
        return LCB * SoSP / 8;
    }

}