// Minh họa cài đặt lớp tĩnh (static class)

// Tạo lớp tĩnh TemperatureConverter dùng để chuyển đổi qua lại giữa độ C/độ F
public static class TemperatureConverter
{
    // Phương thức tĩnh đổi độ C sang độ F
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }

    // Phương thức tĩnh đổi độ F sang độ C
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }
}

// Chương trình chính
class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Chon chuyen doi nhiet do (1: C->F, 2: F->C):");
        string? selection = Console.ReadLine();

        double F = 0, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Nhap do C: ");
                double doC = double.Parse(Console.ReadLine());
                F = TemperatureConverter.CelsiusToFahrenheit(doC);
                Console.WriteLine("Nhiet do (F): {0:F2}", F);
                break;
            case "2":
                Console.Write("Nhap do F: ");
                double doF = double.Parse(Console.ReadLine());
                C = TemperatureConverter.FahrenheitToCelsius(doF);
                Console.WriteLine("Nhiet do (C): {0:F2}", C);
                break;
            default:
                Console.WriteLine("Chon 1 hoac 2.");
                break;
        }
    }
}