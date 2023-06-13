using Dars_6.Entity.Laptop.Enums;

namespace Dars_6.Entity.Laptop;

public class Ram
{
    public int Size { get; set; }
    public string BrandName { get; set; }
    public decimal Price { get; set; }
    public ERamType Type { get; set; }

    internal void PrintInfo()
    {
        Console.WriteLine($"Ram info:" +
                          $"Size: {Size}\n" +
                          $"Brand name: {BrandName}\n" +
                          $"Type: {Type}\n" +
                          $"Price: {Price}");
    }
}
