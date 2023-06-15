using System.Threading.Channels;

namespace Dars_8;

// static kalit so'zi

public  class StaticClass
{
    public static int staticRaqam ;
    static  StaticClass()
    {
        Console.WriteLine("Statik konstruktor ishga  tushdi");
        staticRaqam = 100;
    }
   

    public  int Son { get; set; }

    private static int _staticProperty;

    public static int StaticProperty
    {
        get { return _staticProperty; }
        set { _staticProperty = value; }
    }

    public static void StaticMethod()
    {
        Console.WriteLine($"Static method called { staticRaqam}");
    }

}

public static class Calculator
{
    public static int Add(params  int [] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();
    public static double Add(params  double [] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();
    public static float Add(params  float [] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();
    public static long Add(params  long [] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();
    public static decimal Add(params  decimal [] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();

    public static double Divide(params double[] sonlar)
    {
        if(sonlar == null|| sonlar.Length == 0) throw new NolYokidaNullException("Nol yokida Null Kiriting");

        var answer = sonlar[0];
        for(var index = 0; index < sonlar.Length -1 ; index ++)
        {
            if (index == 0 && (sonlar[0] == 0 || sonlar [0] == 0.0)) return 0;
            if (sonlar[index +1] == 0 || sonlar[index+1] == 0.0) throw new DivideByZeroException();
            answer /= sonlar[index +1];
        }
        return answer;
    }

    public class NolYokidaNullException : Exception
    {
        public NolYokidaNullException(string message)
        {
            Message = message;
            Chiqar();
        }
        public string Message { get; set; }

        public void Chiqar()
        {
            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}