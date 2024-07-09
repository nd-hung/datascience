// Cài đặt lớp Xe (lớp cha)
namespace QuanLyXe
{
    public class Xe
    {
        public string BienSo { get; set; }
        public uint NamSX { get; set; }
        // Hàm thiết lập
        public Xe(string bs = "", uint nsx = 2000)
        {
            BienSo = bs;
            NamSX = nsx;
        }
        // Hàm nhập thông tin xe
        public void Nhap()
        {
            Console.Write("Nhap bien so: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            NamSX = uint.Parse(Console.ReadLine());
        }

        // Hàm in thông tin xe
        public void Xuat()
        {
            Console.WriteLine("Bien so: {0}, nam san xuat: {1}", BienSo, NamSX);
        }
    }

    // Cài đặt lớp xe con kế thừa lớp xe
    public class XeCon : Xe
    {
        public uint SoChoNgoi { get; set; }
        // Hàm thiết lập
        public XeCon(string bs, uint nsx, uint sochongoi) : base(bs, nsx)
        {
            SoChoNgoi = sochongoi;
        }
        // Hàm in thông tin xe con
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi: {0}", SoChoNgoi);
        }
    }
}