// Minh họa đa thừa kế
class Program
{
    public static void Main()
    {
        var dt1 = new MyDateTime();
        dt1.SetDate(29, 2, 2020); // Phương thức SetDate của giao diện IDate
        dt1.SetTime(5, 37, 08);   // Phương thức SetTime của giao diện ITime
        Console.WriteLine(dt1);

        var dt2 = new MyDateTime();
        dt2.SetDate(29, 2, 2023); 
        dt2.SetTime(26, 8, 7);   
        Console.WriteLine(dt2);
    }
}