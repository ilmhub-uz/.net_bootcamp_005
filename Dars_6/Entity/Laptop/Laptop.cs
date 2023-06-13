using Dars_6.Entity.Laptop.Enums;

namespace Dars_6.Entity.Laptop;

public class Laptop
{
    public Laptop() { }

    public Laptop(string name,
        string brandName,
        EColorType color,
        bool isNew) 
        :this(name,
        new DateOnly(2023,08,23),
        1500M,
        ELaptopType.Gaming,
        2.0,
        color,
        isNew)
    {
        Name = name;
        BrandName = brandName;
        Color = color;
        IsNew = isNew;
    }

    public Laptop(string name, 
        DateOnly releaseDate, 
        decimal price, 
        ELaptopType type, 
        double weight,
        EColorType color,
        bool isNew)
    {
        Name = name;
        ReleaseDate = releaseDate;
        Price = price;
        Type = type;
        Weight = weight;
        Color = color;
        IsNew = isNew;
    }

    public Laptop(Screen screen)
    {
        Screen = screen;
    }
    public string Name { get; set; } = null!;
    public string BrandName { get; set; } = string.Empty;
    public DateOnly ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public ELaptopType Type { get; set; } = ELaptopType.Gaming;
    public double Weight { get; set; }
    public Ram Ram { get; set; }
    public EColorType Color { get; set; }
    public Screen Screen { get; set; }
    public LaptopMemory Memory { get; set; }
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public bool IsNew { get; set; }

    public void CloneIt(Laptop laptop)
    {
        Name = laptop.Name;
        BrandName = laptop.BrandName;
        Color = laptop.Color;
        IsNew = laptop.IsNew;
        ReleaseDate = laptop.ReleaseDate;
        Price = laptop.Price;
        Type = laptop.Type;
        Ram = laptop.Ram;
        Memory = laptop.Memory;
        Cpu = laptop.Cpu;
        Gpu = laptop.Gpu;
        Screen = laptop.Screen;
        Weight = laptop.Weight;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"BrandName: {BrandName}");
        Console.WriteLine($"ReleaseDate: {ReleaseDate}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Color: {Color}");
        if(Screen is not null) Screen.PrintInfo();
        if(Memory is not null) Memory.PrintInfo();
        if(Cpu is not null) Cpu.PrintInfo();
        if(Gpu is not null) Gpu.PrintInfo();
        if(Ram is not null) Ram.PrintInfo();
        Console.WriteLine($"IsNew: {IsNew}");
    }
}

