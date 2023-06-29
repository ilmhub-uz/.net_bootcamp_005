namespace OOP.Abstraction;

public abstract class Vehicle
{
    protected string Brand;
    protected DateOnly Year;
    protected string Color;
    protected int EnginePower;

    protected Vehicle(string brand, 
        DateOnly year, 
        string color, 
        int enginePower)
    {
        Brand = brand;
        Year = year;
        Color = color;
        EnginePower = enginePower;
    }

    public abstract void Start();
		
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle has stopped.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($" Brand :{Brand} " +
                          $"Year : {Year}" +
                          $"Color : {Color}"+
                          $" Engine Power : {EnginePower}");
    }
}