namespace Dars_6.Entity.Laptop;

public class Gpu
{
    public string BrandName { get; set; }
    public string Name { get; set; }
    public double Frequency { get; set; } 
    public int Memory { get; set; }
    public decimal Price { get; set; }

    internal void PrintInfo()
    {
        Console.WriteLine($"GPU info:\n" +
                          $"Brandname: {BrandName}\n" +
                          $"Name: {Name}\n" +
                          $"Frequency: {Frequency}\n" +
                          $"Memory: {Memory}" +
                          $"Price: {Price}");
    }
}
