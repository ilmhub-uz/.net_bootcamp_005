using Dars_6.Entity.Laptop.Enums;

namespace Dars_6.Entity.Laptop;

public class Screen
{
    public Screen(int size, bool isTouchScreen, EScreenType type, decimal price)
    {
        Size = size;
        IsTouchScreen = isTouchScreen;
        Type = type;
        Price = price;
    }

    public Screen()
    { }

    public int Size { get; set; }
    public bool IsTouchScreen { get; set; }
    public EScreenType Type { get; set; }
    public decimal Price { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Screen Info:\n" +
                          $"Size : {Size}");
        Console.WriteLine($"Is Touch Screen : {IsTouchScreen}");
        Console.WriteLine($"Type : {Type}");
        Console.WriteLine($"Price : {Price}");
    }
}

