/* Minh họa lớp và đối tượng
Xử lý hình tròn
*/

namespace CircleProject
{
    // Cài đặt lớp tĩnh 
    public static class MyConstants
    {
        // Khai báo hằng số PI
        public const double PI = 3.1416;
    }

    // Cài đặt lớp hình tròn
    class HinhTron
    {
        public double X { get; set; }  // Hoành độ tâm
        public double Y { get; set; }  // Tung độ tâm
        private double banKinh; // Trường (field)
        public double BanKinh   // Thuộc tính (property)
        {
            get { return banKinh; }
            set
            {
                // Nếu giá trị >= 0 mới thực hiện lệnh gán giá trị cho trường banKinh
                if (value >= 0) banKinh = value;
                else Console.WriteLine("Ban kinh phai >= 0.");
            }
        }

        // Khai báo biến tĩnh dùng để lưu tổng số đối tượng được tạo ra
        public static int SoLuong = 0;

        // Hàm thiết lập
        public HinhTron(double x = 0, double y = 0, double r = 0)
        {
            X = x;
            Y = y;
            if (r >= 0) banKinh = r;
            else Console.WriteLine("Ban kinh phai >= 0.");
            // Nếu hình tròn được tạo ra thì tăng số lượng 
            SoLuong++;
        }

        // Hàm thiết lập sao chép (copy constructor)
        public HinhTron(HinhTron c)
        {
            X = c.X;
            Y = c.Y;
            banKinh = c.banKinh;
            // Nếu hình tròn được tạo ra bằng cách này (sao chép) thì tăng số lượng 
            SoLuong++;
        }

        // Hàm in thông tin hình tròn
        public void Xuat()
        {
            Console.WriteLine("Toa do tam: ({0},{1}), ban kinh = {2}\n", X, Y, banKinh);
        }

        // Hàm trả về diện tích hình tròn
        public double DienTich()
        {
            // Tính diện tích hình tròn sử dụng hằng số tự khai báo trong lớp tĩnh
            return MyConstants.PI * banKinh * banKinh;
            // Hoặc sử dụng hằng số PI của lớp tĩnh dựng sẵn Math.PI
            // return Math.PI * banKinh * banKinh;
        }
    }

    // Chương trình chính
    class Program
    {
        public static void Main()
        {
            // Tạo 1 hình tròn với các thuộc tính khởi tạo (sử dụng hàm thiết lập có tham số)
            HinhTron c1 = new HinhTron(1, 2, 3);    // Tâm = (1,2) bán kính = 3
            // In thông tin hình tròn
            Console.WriteLine("Hinh tron thu 1:");
            c1.Xuat();

            // Tạo hình tròn thứ 2 bằng cách sao chép (sử dụng hàm thiết lập sao chép)
            HinhTron c2 = new HinhTron(c1);
            // Thay đổi bán kính của c2
            c2.BanKinh = 21;
            // In thông tin hình tròn thứ 2
            Console.WriteLine("Hinh tron thu 2:");
            c2.Xuat();
            Console.WriteLine("Dien tich = {0:0.000}", c2.DienTich());

            // Tạo đối tượng hình tròn 3 (gán giá trị bán kính không hợp lệ và kiểm tra kết quả)
            Console.WriteLine("Hinh tron thu 3:");
            HinhTron c3 = new HinhTron(4, 5, -10);

            // In diện tích hình tròn, làm tròn đến 3 chữ số phần thập phân
            Console.WriteLine("Dien tich = {0:0.000}", c3.DienTich());

            // In số lượng hình tròn được tạo ra
            // Lưu ý truy cập thuộc tính tĩnh theo cú pháp <Tên lớp>.<Tên thuộc tính>
            Console.WriteLine("So hinh tron = {0}", HinhTron.SoLuong);
        }
    }
}