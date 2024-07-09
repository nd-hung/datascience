class FileWriter
{
    static void Main()
    {
        // Mở file để ghi
        StreamWriter writer = new StreamWriter("numbers.txt");
        // Dùng lệnh using(writer) để tự động đóng luồng khi hoàn thành
        using (writer)
        {
            // Lưu các số nguyên từ 1-20 trên một dòng, cách nhau 1 khoảng trắng
            for (int i = 1; i <= 20; i++)
            {
                writer.Write("{0} ", i);
            }
        }
    }
}