using System.Net.NetworkInformation;
using System.Threading.Channels;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace Dars_8;

// static kalit so'zi
class MyClass
{
    public readonly int Count = 0;

    public MyClass()
    {
        
    }

    public void UpdateCount()
    {
        //Count++;  // Error: Cannot modify a readonly field
    }
}

public class ImmutablePerson
{
    public readonly string Name;
    public readonly int Age;

    public ImmutablePerson(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
public  class StaticClass
{
    public readonly int _MaxValue;

    private readonly ILogger<StaticClass> _logger;

    private readonly int _minValue = 100;

    public StaticClass()
    {
        
    }
    public StaticClass(int son, ILogger<StaticClass> logger)
    {
        _MaxValue = son;
        _logger = logger;
    }


    public const int Sanoq = 1000;

    public const string TEST = "Ass";

    public static int staticRaqam ;
    //static  StaticClass()
    //{
    //    Console.WriteLine("Statik konstruktor ishga  tushdi");
    //    staticRaqam = 100;
    //}
   


    public  int Son { get; set; }

    private static int _staticProperty;

    public static int StaticProperty
    {
        get { return _staticProperty; }
        set { _staticProperty = value; }
    }

    public static void StaticMethod()
    {
        var summa = 100;
        var foiz = summa * 0.2;

        Console.WriteLine(Sanoq);

        Console.WriteLine($"Static method called { staticRaqam}");
    }

}
