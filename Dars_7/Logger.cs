namespace Dars_7;

//public class Logger
//{
//    //private static Logger _instance;
//    //public static Logger GetInstance () 
//       // => _instance ??= new Logger();

//    //Readonly Property
//    public static Logger Instance { get; } = new ();

//    public string LogFile { private get; set; }

//    private Logger(){}

//}

//public class Logger
//{
//    private string logMessage;

//    public string LogMessage
//    {
//        set { logMessage = value; }
//    }

//    public void Log()
//    {
//        Console.WriteLine(logMessage);
//    }
//}

//public class BankAccount
//{
//    private  decimal _balance;

//    public decimal SetBalance
//    {
//        set { _balance = value; }
//    }
//}

//public class Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public double Area => Length * Width;
//}

//public class Circle
//{
//    private double radius;

//    public double Radius
//    {
//        get { return radius; }
//    }

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//public double CalculateArea()
//{
//    return Math.PI * Radius * Radius;
//}
//}



//public class Animal
//{
//    public string Name { get; init; }
//}

public struct Animal
{
    public string Name { get; init; }
}

public struct DateTimeRange
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public TimeSpan Duration => End - Start;
}

