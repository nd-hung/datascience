/*
Viết chương trình xử lý danh sách phân số
- Nhập danh sách
- Xuất danh sách
- Tìm phân số lớn nhất
- Sắp xếp danh sách phân số dần
*/
namespace DSPhanSo
{

    public class PhanSo
    {
        // fields
        private int tuSo;
        private int mauSo;
        // properties
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { if (value != 0) mauSo = value; }
        }
        // Constructor

        public PhanSo(int ts = 0, int ms = 1)
        {
            tuSo = ts;
            mauSo = ms;
        }
        // Ham nhap phan so
        public void Nhap()
        {
            Console.Write("Tu so = ");
            tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Mau so = ");
                mauSo = int.Parse(Console.ReadLine());
            } while (mauSo == 0);
        }
        // Ham in phan so
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }
        // Hàm trả về giá trị thực của phân số
        public double GetValue()
        {
            return (double)tuSo / mauSo;
        }

    }
    // Lớp quản lý danh sách phân số
    public class DSPhanSo
    {
        public int SoLuong { get; set; } // So luong phan so
        PhanSo[] PhanSoList;

        // Ham nhap danh sach phan so
        public void Nhap()
        {
            // Nhap so luong phan so
            Console.Write("So luong phan so = ");
            SoLuong = int.Parse(Console.ReadLine());
            // Nhap mang phan so
            PhanSoList = new PhanSo[SoLuong];
            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine("Phan so thu {0}\n", i + 1);
                PhanSoList[i] = new PhanSo();
                PhanSoList[i].Nhap();
            }
        }
        // Ham in danh sach phan so
        public void Xuat()
        {
            Console.WriteLine("\nDanh sach phan so:\n");
            for (int i = 0; i < SoLuong; i++)
                PhanSoList[i].Xuat();
        }

        // Tìm phân số lớn nhất
        public void PhanSoMax()
        {
            double max = PhanSoList[0].GetValue();
            int maxIndex = 0;
            for (int i = 1; i < SoLuong; i++)
                if (PhanSoList[i].GetValue() > max)
                {
                    max = PhanSoList[i].GetValue();
                    maxIndex = i;
                }
            // In ra phân số lớn nhất
            Console.WriteLine("Phan so lon nhat la: ");
            PhanSoList[maxIndex].Xuat();
        }
    }

    // Main program
    internal class Program
    {
        public static void Main()
        {
            // Tạo & nhập danh sách phân số 
            DSPhanSo ds = new DSPhanSo();
            ds.Nhap();
            // In danh sách phân số
            ds.Xuat();
            // In phân số lớn nhất
            ds.PhanSoMax();
        }
    }

}