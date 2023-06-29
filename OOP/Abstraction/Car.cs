namespace OOP.Abstraction;

public class Car : Vehicle
{
    public Car(string brand, DateOnly year,string color,int enginePower) 
        : base(brand, year,color,enginePower)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Car has stopped.");
    }
}