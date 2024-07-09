class FileReader
{
    static void Main()
    {
        // Tạo luồng kết nối tới file text
        StreamReader reader = new StreamReader(@"data\textfile.txt");  // đường dẫn tương đối
        int lineNumber = 0;
        // Đọc dòng đầu tiên từ file
        string line = reader.ReadLine();
        // Đọc các dòng còn lại
        while (line != null)
        {
            lineNumber++;
            Console.WriteLine("Line {0}: {1}", lineNumber, line);
            line = reader.ReadLine();
        }
        // Đóng luồng sau khi xử lý xong
        reader.Close();
    }
}