# Xử lý file

File handling

---

## Sơ lược về luồng nhập xuất (streams)

- Luồng (streams) là thành phần cơ bản của thư viện nhập xuất, sử dụng để truy xuất dữ liệu lên bộ nhớ ngoài.
Một luồng là một dãy các bytes được gửi từ một ứng dụng hoặc thiết bị nhập đến một ứng dụng khác hoặc thiết bị xuất.
- Mỗi khi muốn đọc/ghi dữ liệu từ/lên file, cần phải mở một luồng cho file tương ứng, tiến hành đọc/ghi dữ liệu, và đóng luồng khi quá trình đọc/ghi hoàn tất.

## Các loại luồng dữ liệu

### Luồng nhị phân (binary streams)

- Luồng nhị phân dùng để xử lý file nhị phân (mọi loại file): hình ảnh, âm thanh, văn bản,...
- Các lớp dựng sẵn xử lý file nhị phân: FileStream, BinaryReader, BinaryWriter.

Lớp FileStream cung cấp các phương thức đọc/ghi file nhị phân theo từng byte riêng lẻ hoặc dãy bytes.

Lớp BinaryWriter cho phép ghi dữ liệu kiểu cơ sở (int, char, bool, string, ...) lên luồng xử lý.

Lớp BinaryReader cung cấp các phương thức đọc dữ liệu được ghi bởi phương thức của lớp BinaryWriter.

### Luồng văn bản (text streams)

- Dùng để xử lý file văn bản - là một dãy ký tự.
- Các lớp chính dùng để xử lý file văn bản của .NET là TextReader và TextWriter. Hai lớp này đều là lớp trừu tượng, định nghĩa các phương thức xử lý file trong đó có các phương thức quan trọng sau:
    ReadLine(): đọc một dòng văn bản và trả về một chuỗi.
    ReadToEnd(): đọc từ luồng hiện tại đến hết và trả về một chuỗi.
    Write(): ghi một chuỗi vào luồng đang mở.
    WriteLine(): ghi một dòng văn bản vào luồng đang mở.

- Lớp StreamReader kế thừa lớp trừu tượng TextReader và cài đặt các phương thức đọc văn bản.
- Lớp StreamWriter kế thừa lớp trừu tượng TextWriter và cài đặt các phương thức ghi văn bản.

> Trong .NET xử lý ký tự theo Unicode.

### Các thao tác cơ bản với luồng

- Tạo luồng (Create): trước hết cần tạo luồng để kết nối đến nguồn dữ liệu.
- Đọc dữ liệu (Read): lấy dữ liệu từ luồng.
- Ghi dữ liệu (Write): gửi dữ liệu đến luồng theo một cách xác định.
- Định vị (Seek/Position): di chuyển vị trí hiện hành của luồng.
- Đóng luồng (Close): ngắt kết nối luồng, giải phóng tài nguyên.

## Đường dẫn (paths)

- Đường dẫn là một chuỗi xác định vị trí của tập tin/thư mục trong ổ đĩa máy tính.
### Đường dẫn đầy đủ (full path)

- Đường dẫn đầy đủ là chuỗi xác định vị trí của tập tin/thư mục trong ổ đĩa, bắt đầu từ tên ổ đĩa. Ví dụ: `C:\oop\labs\data\textfile.txt`
- Khai báo đường dẫn đầy đủ trong C#:

```c#
// Cách 1
string fileName = "C:\\oop\\labs\\data\\textfile.txt";
// Cách 2
string theSameFileName = @"C:\oop\labs\data\textfile.txt";
```

### Đường dẫn tương đối (relative paths)

- Đường dẫn tương đối là chuỗi xác định vị trí tương đối của tập tin/thư mục so với vị trí hiện hành của ứng dụng.
- Ví dụ: `@"..\data\textfile.txt"` chỉ ra vị trí của file `textfile.txt` nằm ở thư mục `data`, còn thư mục `data` nằm cùng cấp với thư mục cha của vị trí hiện tại.

> Nên sử dụng đường dẫn tương đối giúp ứng dụng linh hoạt hơn.

## Đọc file văn bản

```c#
// Dùng đối tượng lớp StreamReader để tạo luồng kết nối tới file text
StreamReader reader = new StreamReader("text_file_name.txt");
// Đọc file
// Đóng luồng xử lý sau khi kết thúc
reader.Close();
```

- Ví dụ: ([Xem trên GitHub](https://github.com/nd-hung/oop/tree/main/docs/topics/filehandling/code/ReadFileExample))

```c#
class FileReader
{
    static void Main()
    {
        // Sử dụng đường dẫn tương đối
        StreamReader reader = new StreamReader(@"data\textfile.txt");  
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

/* Output
Line 1: This is line #1
Line 2: This is line #2
Line 3: This is line #3
*/
```
## Ghi file văn bản

- Sử dụng lớp StreamWriter để ghi file văn bản.

```c#
// Tạo luồng kết nối tới file text để ghi
StreamWriter writer = new StreamWriter("text_file_name.txt");
// Ghi file
// Đóng luồng xử lý sau khi kết thúc
writer.Close();
```

- Ví dụ: Ghi một dãy số lên file văn bản

```c#
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
```
