// Minh họa nạp chồng toán tử

// Định nghĩa lớp phân số
public class PhanSo
{
    private int tuSo;
    private int mauSo;

    // Hàm thiết lập
    public PhanSo(int ts, int ms)
    {   // Mẫu số phải khác 0
        if (ms == 0)
        {
            throw new ArgumentException("Mau so phai khac 0.", nameof(ms));
        }
        tuSo = ts;
        mauSo = ms;
    }

    // Định nghĩa toán tử + 
    public static PhanSo operator +(PhanSo p) => p;
    // Định nghĩa toán tử -
    public static PhanSo operator -(PhanSo p) => new PhanSo(-p.tuSo, p.mauSo);

    // Định nghĩa toán tử cộng 2 phân số
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
    }

    // Định nghĩa toán tử trừ 2 phân số
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return a + (-b);
    }

    public override string ToString() => $"{tuSo} / {mauSo}";
}

// Chương trình chính
public static class TestOperatorOverloading
{
    public static void Main()
    {
        var a = new PhanSo(5, 4);
        var b = new PhanSo(1, 2);
        Console.WriteLine(-a);     // output: -5 / 4
        Console.WriteLine(a + b);  // output: 14 / 8
        Console.WriteLine(a - b);  // output: 6 / 8
    }
}