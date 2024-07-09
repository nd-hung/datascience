/* Minh họa kỹ thuật đa hình - Chương trình chính
*/
class Program
{
    public static void Main()
    {
        // Tạo một danh dách các hình vẽ khác nhau
        var shapes = new List<Shape>
        {
            new Rectangle(9,6), // Hình chữ nhật (độ dài các cạnh)
            new Circle(1),      // Hình tròn (bán kính)
            new Circle(2.5),
            new Rectangle(6,9),
            new Circle(2.3)
        };

        // In thông tin của mỗi hình & tìm diện tích lớn nhất
        double maxArea = 0;
        foreach (var s in shapes)
        {
            Console.WriteLine("This is a {0}, area = {1:0.000}", s.GetType(), s.GetArea());
            if (s.GetArea() > maxArea) maxArea = s.GetArea();
        }

        // In thông tin (các) hình vẽ có diện tích lớn nhất
        Console.WriteLine("Cac hinh ve co dien tich lon nhat:");
        for (int i = 0; i < shapes.Count; i++)
            if (shapes[i].GetArea() == maxArea)
            {
                Console.WriteLine("Index = {0}, type: {1}, area = {2:0.000}", i, shapes[i].GetType(), shapes[i].GetArea());
            }
    }
}