// Cài đặt lớp phân số

public class PhanSo
{
    // Khai báo các trường (fields)
    private int tuSo;
    private int mauSo;

    // Các thuộc tính (properties)
    public int TuSo
    {
        get { return tuSo; }
        set { tuSo = value; }
    }
    public int MauSo
    {
        get { return tuSo; }
        set { if (value != 0) mauSo = value; }
    }

    // Phương thức thiết lập
    public PhanSo(int ts = 0, int ms = 1)
    {
        tuSo = ts;
        if (ms != 0) mauSo = ms;
    }

    // Phương thức nhập phân số từ bàn phím
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

    // Phương thức in phân số
    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", tuSo, mauSo);
    }

    // Phương thức tối giản phân số
    public void ToiGian()
    {
        // Tìm UCLN của tử số và mẫu số
        int ucln = MyMath.UCLN(tuSo, mauSo);
        tuSo /= ucln;
        mauSo /= ucln;
    }
}

// Lớp chứa thư viện các hàm toán học tự định nghĩa (lớp tĩnh)
public static class MyMath
{
    // Phương thức tìm UCLN của 2 số nguyên (phương thức tĩnh)
    public static int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        int min = (a > b) ? b : a;
        int ucln = 1;
        for (int i = min; i >= 1; i--)
            if (a % i == 0 && b % i == 0)
            {
                ucln = i;
                break;
            }
        return ucln;
    }
}