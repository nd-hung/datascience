public class Car
{
    public string? Manufacturer;    // Tên hãng sản xuất

    // Hàm thiết lập không tham số
    public Car()
    {
        Manufacturer = "Toyota";
    }

    // Hàm thiết lập có tham số
    public Car(string? mnf = "")
    {
        Manufacturer = mnf;
    }

    // Hàm in thông tin hãng xe
    public void Print()
    {
        Console.WriteLine("Manufacturer: " + Manufacturer);
    }
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng xe, gọi hàm thiết lập không tham số
        Car car1 = new Car();
        car1.Print();

        // Tạo đối tượng xe, gọi hàm thiết lập có tham số
        Car car2 = new Car("Ford");
        car2.Print();
    }
}
