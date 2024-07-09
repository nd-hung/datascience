# .NET và C# #

---

# Ngôn ngữ lập trình C# ##

- C# là ngôn ngữ lập trình hướng đối tượng được sử dụng rộng rãi hiện nay. C# cung cấp khả năng tạo nhiều loại ứng dụng khác nhau trên nền tảng .NET.

## Các kiểu dữ liệu của C# ##

### Lớp và đối tượng

- Lớp (class) và đối tượng (object) là hai thành phần cơ bản của lập trình hướng đối tượng. Một lớp là một cấu trúc dữ liệu kết hợp dữ liệu (gọi là thuộc tính - properties) và các xử lý với dữ liệu đó (gọi là phương thức - methods) vào một đơn vị thống nhất. Đối tượng là một thực thể tạo ra từ lớp.

- Ví dụ sau khai báo lớp Point mô tả các điểm trong mặt phẳng:

```cs
public class Point
{
    public int X { get; }       // Hoành độ
    public int Y { get; }       // Tung độ
    
    public Point(int x, int y)  // Hàm thiết lập (constructor)
    {
        X = x;
        Y = y;
    }
}
```

## Nền tảng .NET

[.NET - do Microsoft phát triển](https://learn.microsoft.com/en-us/dotnet/) - là nền tảng lập trình miễn phí và mã nguồn mở. Với .NET có thể tạo
