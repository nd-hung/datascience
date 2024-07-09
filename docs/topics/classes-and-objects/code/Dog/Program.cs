// Khai báo lớp mô tả loài chó 
public class Dog
{
    public string Name;
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng của lớp 
        Dog dog = new Dog();
        // Thay đổi giá trị thuộc tính 
        dog.Name = "Cau Vang";
        // Đọc thuộc tính
        Console.WriteLine("The dog's name is " + dog.Name);
    }
}