namespace TinhTienDien
{
    class Program
    {
        // Khai báo các hằng 
        // Các mức tiêu thụ (kWh)
        const int Muc1 = 100, Muc2 = 150, Muc3 = 300;
        // Các mức giá (VND/kWh)
        const int Gia1 = 2000, Gia2 = 2500, Gia3 = 3000;

        static void Main()
        {
            int sokWh = 0;
            double sotien = 0;

            // Nhập số kWh tiêu thụ 
            Console.Write("Nhap so kWh tieu thu: ");
            sokWh = int.Parse(Console.ReadLine()); 
            // Hãy sửa lại đoạn code trên để chương trình kiểm soát được số liệu nhập vào hợp lệ (là số nguyên và giá trị >= 0)
            // HD: Sử dụng điều khiển do .. while và phương thức int.TryParse()

            // Tính tiền điện dựa vào số kWh tiêu thụ và Bảng giá
            if (sokWh <= 0) sotien = 0;
            else if (sokWh <= Muc1) sotien = sokWh * Gia1;
            else if (sokWh <= Muc2) sotien = Muc1 * Gia1 + (sokWh - Muc1) * Gia2;
            else if (sokWh <= Muc3) sotien = Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (sokWh - Muc2) * Gia3;
            // Nếu tiêu thụ quá 300 thì cộng thêm 10% tổng tiền
            else sotien = (Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (sokWh - Muc2) * Gia3) * 1.1;

            // Output
            Console.WriteLine("So kWh tieu thu: {0}, so tien: {1:#.00} (vnd)", sokWh, sotien);
        }
    }
}