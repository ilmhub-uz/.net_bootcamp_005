namespace OOP.Abstraction;

public class Motorcycle : Vehicle
{
    public Motorcycle(string brand, DateOnly year,string color,int enginePower) 
        : base(brand, year, color, enginePower)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Motorcycle is started.");
    }

    
}