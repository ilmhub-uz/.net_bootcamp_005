namespace OOP.Abstraction;

public class Car : Vehicle
{
    public Car()
    {
        
    }


    public Car(string brand, DateOnly year,string color,int enginePower)
    {
        Brand = brand;
        Year = year;
        Color = color;
        EnginePower = enginePower;
    }

    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine(" Car Stopped");
    }
}