// Minh họa nạp chồng phương thức của lớp dẫn xuất và lớp cơ sở

// Tạo lớp cơ sở Animal
public class Animal
{
    public void SayHi() // Phương thức SayHi() có mức truy cập public nên lớp con được sử dụng
    {
        Console.WriteLine("I'm an animal.");
    }
}

// Tạo lớp Cat kết thừa lớp Animal
public class Cat : Animal
{
    // Phương thức SayHi() của lớp con trùng tên nhưng khác tham số với phương thức SayHi() của lớp cha
    public void SayHi(string message)
    {
         Console.WriteLine(message);
    }
}

// Chương trình chính
public class Program
{
    public static void Main()
    {
        Cat cat1 = new Cat();
        cat1.SayHi();   // Phương thức của lớp cha được gọi
        cat1.SayHi("I'm a cat, my name is Thomas.");    // Phương thức của lớp con được gọi
    }
}
