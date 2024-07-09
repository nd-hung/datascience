// Minh họa ghi đè phương thức (method overriding)

namespace MethodOverridingDemo
{
    // Định nghĩa lớp Shape mô tả các hình vẽ tổng quát
    public class Shape
    {
        protected string name; // Trường name chia sẻ cho lớp kế thừa
        public string Name { get => name; }
        // Hàm thiết lập
        public Shape(string name = "Shape")
        { this.name = name; }
        // Hàm tính diện tích
        public virtual double Area()
        {
            // Chưa phải hình vẽ cụ thể nên chưa thể tính diện tích
            return 0;
        }
    } // Kết thúc lớp Shape

    // Định nghĩa lớp Square mô tả các hình vuông, kế thừa lớp Shape
    public class Square : Shape
    {
        // Hình vuông có thuộc tính độ dài cạnh
        private double side;
        public double Side { get => side; }

        // Hàm thiết lập: khởi tạo tên gọi và độ dài cạnh hình vuông
        public Square(string name = "Square", double side = 0) : base(name)
        {
            this.side = side;
        }

        // Hàm tính diện tích - Ghi đè hàm cùng tên của lớp Shape
        public override double Area()
        {
            // Ở đây là hình vẽ cụ thể (hình vuông) nên tính được diện tích
            return side * side;
        }
    } // Kết thúc lớp Square

    // Định nghĩa lớp Circle mô tả các hình tròn, kế thừa lớp Shape
    public class Circle : Shape
    {
        // Hình tròn có thuộc tính độ dài bán kính
        private double radius;
        public double Radius { get => radius; }

        // Hàm thiết lập: khởi tạo tên gọi và độ dài bán kính hình tròn
        public Circle(string name = "Circle", double radius = 0) : base(name)
        {
            this.radius = radius;
        }

        // Hàm tính diện tích - Ghi đè hàm cùng tên của lớp Shape
        public override double Area()
        {
            // Ở đây là hình vẽ cụ thể (hình tròn) nên tính được diện tích
            return Math.PI * radius * radius;
        }
    } // Kết thúc lớp Circle

    // Chương trình chính
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng hình vẽ
            Shape shape = new Shape("General shape");
            Console.WriteLine("This is a {0}, area = {1:0.00}", shape.Name, shape.Area());

            // Tạo đối tượng hình vuông
            Shape square = new Square("Square", 5);
            Console.WriteLine("This is a {0}, area = {1:0.00}", square.Name, square.Area());

            // Tạo đối tượng hình tròn
            Shape circle = new Circle("Circle", 1);
            Console.WriteLine("This is a {0}, area = {1:0.00}", circle.Name, circle.Area());
        }
    }
}