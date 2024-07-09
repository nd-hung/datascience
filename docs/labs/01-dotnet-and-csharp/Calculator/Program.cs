/* Chương trình Console đọc 2 số nguyên và một phép toán, in ra kết quả tương ứng*/
namespace SimpleCalculator
{
    internal class Program
    {
        public static void Main()
        {
            int a, b;   // Khai báo 2 biến chứa giá trị đọc từ bàn phím
            bool readNumberOK = false; // Dùng để kiểm tra giá trị đọc vào có hợp lệ không

            // Lặp lại việc đọc số thứ nhất cho đến khi giá trị hợp lệ
            do
            {
                Console.Write("Nhap so thu nhat = ");
                readNumberOK = int.TryParse(Console.ReadLine(), out a);
            } while (!readNumberOK);

            // Lặp lại việc đọc số thứ hai đến khi giá trị hợp lệ
            do
            {
                Console.Write("Nhap so thu hai = ");
                readNumberOK = int.TryParse(Console.ReadLine(), out b);
            } while (!readNumberOK);

            // Đọc ký hiệu phép toán (đọc 1 ký tự)
            Console.Write("Nhap ky hieu phep toan (+,-,*,/) = ");
            char op = Console.ReadKey().KeyChar;

            // Kiểm tra phép toán và tính biểu thức tương ứng
            switch (op)
            {
                case '+': Console.WriteLine("\n{0} + {1} = {2}", a, b, a + b); break;
                case '-': Console.WriteLine("\n{0} - {1} = {2}", a, b, a - b); break;
                case '*': Console.WriteLine("\n{0} * {1} = {2}", a, b, a * b); break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("\nKhong chia duoc!");
                    else
                        Console.WriteLine("\n{0}/{1} = {2}", a, b, (double)a / b);
                    break;
                default: Console.WriteLine("\nKhong biet phep toan!"); break;
            }
        }
    }
}