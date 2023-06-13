using System.Drawing;

namespace Dars_6.Entity.Laptop;

public class Cpu
{
    public string BrandName { get; set; } = string.Empty;
    public  string  Name { get; set; }
    public int CoreCount { get; set; }
    public double Frequency { get; set; }
    public decimal Price { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"CPU info:\n" +
                          $"Brandname: {BrandName}\n" +
                          $"Name: {Name}\n" +
                          $"Core count: {CoreCount}" +
                          $"Frequency: {Frequency}\n" +
                          $"Price: {Price}");
    }
}