class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng Người
        Nguoi n1 = new Nguoi("Nguyen Van Ba", false);
        // In thông tin người
        n1.Xuat();

        // Tạo đối tượng sinh viên
        SinhVien sv1 = new SinhVien("Le Van Hoang", false, "64131234", 8.97);
        // In thông tin sinh viên
        sv1.Xuat();
    }
}
