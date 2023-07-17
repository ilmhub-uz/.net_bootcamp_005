namespace OOP.Abstraction;

public class ElectroCar : Car
{
    public ElectroCar()
    {
        
    }
    public ElectroCar(string name, DateOnly year,string color,int enginePower)
     : base (name,year,color,enginePower)
    {
        
    }

    public override void Start()
    { 
        Console.WriteLine(" Tesla Started");
    }

    public override void Stop() 
    {
        Console.WriteLine(" Tesla Stopped");
    }
}
