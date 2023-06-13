using Dars_6.Entity.Laptop.Enums;

namespace Dars_6.Entity.Laptop;

public class LaptopMemory
{
    public int Size { get; set; }
    public EMemoryType Type { get; set; }
    public double Frequency { get; set; }
    public decimal Price { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Memory info:" +
                          $"Size: {Size}\n" +
                          $"Type: {Type}\n" +
                          $"Frequency: {Frequency}\n" +
                          $"Price: {Price}");
    }
}