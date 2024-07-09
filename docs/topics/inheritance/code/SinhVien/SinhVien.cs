// Cài đặt các lớp Người và Sinh viên, trong đó lớp Sinh viên kế thừa lớp Người

// Lớp Người
public class Nguoi
{
    // Các thuộc tính cho phép kế thừa
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; }

    // Phương thức thiết lập
    public Nguoi() {HoTen="";}    // PT thiết lập không tham số
    public Nguoi(string ht = "", bool gt = false)   // PT thiết lập có tham số
    {
        HoTen = ht;
        GioiTinh = gt;
    }
    // Phương thức nhập thông tin
    public void Nhap()
    {
        Console.WriteLine("Ho ten: ");
        HoTen = Console.ReadLine();
        int gt;
        do
        {
            Console.WriteLine("Phai (nu: 1, nam: 0)");
            gt = int.Parse(Console.ReadLine());
        } while (!(gt == 0 || gt == 1));
    }

    // Phương thức in thông tin người
    public void Xuat()
    {
        string phai = "";
        if (GioiTinh == true) phai = "Nu";
        else phai = "Nam";
        Console.WriteLine("Ho ten: {0}, phai: {1}", HoTen, phai);
    }
}

// Cài đặt lớp SinhVien kế thừa lớp Nguoi
public class SinhVien : Nguoi
{
    public string MSSV { get; set; }
    public double DTB { get; set; }

    // Phương thức thiết lập không tham số
    public SinhVien() : base() {MSSV="";}
    // Phương thức thiết lập có tham số
    public SinhVien(string ht, bool gt, string ms, double dtb) : base(ht, gt)
    {
        MSSV = ms;
        DTB = dtb;
    }
    // Phương thức nhập thông tin sinh viên
    public new void Nhap()
    {
        // Gọi phương thức nhập của lớp cha
        base.Nhap();
        Console.WriteLine("Nhap MSSV: ");
        MSSV = Console.ReadLine();
        Console.WriteLine("Nhap diem trung binh: ");
        DTB = double.Parse(Console.ReadLine());
    }

    // Phương thức xuất thông tin sinh viên
    public new void Xuat()
    {
        // Gọi phương thức xuất của lớp cha
        base.Xuat();
        Console.WriteLine("MSSV: {0}, DTB: {1}", MSSV, DTB);
    }
}