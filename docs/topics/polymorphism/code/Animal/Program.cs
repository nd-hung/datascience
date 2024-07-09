/* Minh họa kỹ thuật đa hình */

// Tạo lớp cơ sở Animal mô quả động vật tổng quát
public class Animal
{
    public string Name;

    // Constructor
    public Animal(string name = "")
    {
        Name = name;
    }
    // Tạo phương thức ảo (virtual) phát ra tiếng kêu 
    public virtual void Speak()
    {
        Console.WriteLine("Hello, I'm an animal.");
    }
}

// Tạo lớp dẫn xuất Dog kế thừa lớp Animal
public class Dog : Animal
{
    // Constructor
    public Dog(string name = "") : base(name) { }
    // Tạo phương thức ghi đè (override) phát ra tiếng kêu của loài chó
    public override void Speak()
    {
        Console.WriteLine("Wufwuf, I'm a dog. My name is " + Name);
    }
}

// Tạo lớp dẫn xuất Cat kế thừa lớp Animal
public class Cat : Animal
{
    // Constructor
    public Cat(string name = "") : base(name) { }

    // Tạo phương thức ghi đè (override) phát ra tiếng kêu của loài mèo
    public override void Speak()
    {
        Console.WriteLine("Meow, I'm a cat. My name is " + Name);
    }
}

// Chương trình chính
public class DemoPolymorphism
{
    public static void Main()
    {
        // Tạo một danh sách loài vật
        var animals = new List<Animal>
        {
            new Dog("Shiba"),
            new Cat("Tom"),
            new Cat("Doreamon"),
            new Dog("Tyke")
        };

        // In thông tin của mỗi hình & tìm diện tích lớn nhất
        foreach (var pet in animals)
        {
            pet.Speak();
        }
    }
}

/* Output
Wufwuf, I'm a dog. My name is Shiba
Meow, I'm a cat. My name is Tom
Meow, I'm a cat. My name is Doreamon
Wufwuf, I'm a dog. My name is Tyke
*/