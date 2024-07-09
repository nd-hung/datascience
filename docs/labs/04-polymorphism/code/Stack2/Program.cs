class Program
{
    // Hàm PhanTichThua số nhận vào số tự nhiên n 
    // và trả về ngăn xếp chứa các thừa số nguyên tố của n
    public static Stack PhanTichThuaSo(int n)
    {
        Stack stack = new PrimeStack();
        for(int i=2; i <=n; i++)
        {
            while(n % i ==0)
            {
                stack.Push(i);        
                n /= i;
            }
        }
        return stack;
    }

    // Hàm Dec2Hex số nhận vào số tự nhiên n 
    // và trả về ngăn xếp chứa các dư số của n chia cho 16
    public static Stack Dec2Hex(int n)
    {
        Stack stack = new HexaStack();
        while(n > 0)
        {
            int soDu = n % 16;
            stack.Push(soDu);
            n /= 16;
        }
        return stack;
    }

    // Chương trình chính
    static void Main(string[] args)
    {
        int n;
        
        // Input
        do{
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
        }while(n < 2);
        
        // Phân tích n thành thừa số nguyên tô
        Stack stack1 = PhanTichThuaSo(n);
        Console.Write("{0} = ", n);
        // In ra kết quả
        stack1.Print();

        // Đổi n sang hệ 16
        Stack stack2 = Dec2Hex(n);
        Console.Write("So {0} bieu dien trong he 16 la ", n);
        // In kết quả
        stack2.Print();
    }
}