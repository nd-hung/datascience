// Minh họa ẩn phương thức lớp cơ sở

namespace BaseMethodHidingDemo
{
    public class Person
    {
        protected string? name;

        // Phương thức nhập 
        public void Input()
        {
            Console.Write("Ho va ten: ");
            name = Console.ReadLine();
        }

        // Phương thức xuất thông tin
        public void Print()
        {
            Console.WriteLine(name);
        }
    } // Kết thúc lớp Person

    // Định nghĩa lớp Student mô tả sinh viên, kế thừa lớp Person
    public class Student : Person
    {
        // Ngoài họ tên (kế thừa lớp Person), sinh viên có các thuộc tính mã sinh viên, điểm trung bình
        private string? maSV;
        private double dtb;

        // Phương thức nhập - ẩn phương thức cùng tên của lớp cơ sở
        public new void Input()
        {
            base.Input(); // Gọi phương thức cùng tên của lớp cha (khỏi phải viết lại)
            Console.Write("Ma SV: ");
            maSV = Console.ReadLine();
            Console.Write("Diem trung binh: ");
            dtb = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin
        public new void Print()
        {
            base.Print();
            Console.WriteLine("MSSV: {0}\tDTB: {1}", maSV, dtb);
        }
    }

    // Chương trình chính
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng sinh viên
            Student sv = new Student();
            sv.Input();
            sv.Print();
        }
    }
}