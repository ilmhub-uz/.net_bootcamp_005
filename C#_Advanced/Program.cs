namespace C__Advanced;

static class  Program
{
    static void Main(string[] args)
    {
        //PrintDelegate printDelegate = PrintMessage;

        //var print = new PrintDelegate(PrintMessage);

        //printDelegate("birinchi delegate ishladi");

        //print("Print digan delegate ishladi");


        MathOperationDelegate mathDelegate = new(Subtract);
        mathDelegate += Add;
        mathDelegate += Multiply;

        //mathDelegate(10);
        //mathDelegate.Invoke(20);

        //CalculationDelegate calculationDelegate = (a, b) => a + b;
        //int.TryParse(Console.ReadLine(),out var son);
        //var result = calculationDelegate.DynamicInvoke(5,son);
        ////int result = calculationDelegate.Invoke(3,5);
        //Console.WriteLine("Result: " + result);


        ////remove Method1
        //mathDelegate -= Add;

        //mathDelegate(10);


        // copy AllMethodsDelegate while removing d2
        //var oneMethodDelegate = mathDelegate - Multiply;

        //var obj = new MethodClass();
        //Delegate d1 = obj.Method1;
        //Delegate d2 = obj.Method2;
        //Delegate d3 = new(DelegateMethod);

        ////Both types of assignment are valid.
        //Delegate allMethodsDelegate = d2 +d1 + d3 ;
        //Console.WriteLine($"Methods count in our delegate {allMethodsDelegate.GetInvocationList().Length}");
        //allMethodsDelegate += d3;
        //Console.WriteLine($"Methods count in our delegate {allMethodsDelegate.GetInvocationList().Length}");

        //allMethodsDelegate.Invoke("D3");


        //FileProcessor fileProcessor = new ();

        //fileProcessor.ProcessFile("example.txt", FileProcessingCompleted);
        //fileProcessor.ProcessFile("example.txt", DelegateMethod);

        //HandlerMethod handlerMammals = MammalsHandler;
		
        //// Covariance enables this assignment.
        //HandlerMethod handlerDogs = DogsHandler;


        //Func<int, int, int,string> add = (x, y, z) => (x + y + z).ToString();
        //Console.WriteLine(add(2, 3, 4));

        //Action<string,int,double> printMessage = (message,son,qoldiq) => Console.WriteLine($"{message} {son} {qoldiq}");
        //printMessage.Invoke("Hello, delegates!",23,1234.56); 

        //Predicate<int> isEven = (number) => number % 2 == 0;
        //bool result = isEven(4); // result = true

        //var even = isEven(5);
        //Console.WriteLine(result);
        //Console.WriteLine(even);

        //var list = new List<int>();
        //list.Add(1);
        //list.Add(2);
        //Console.WriteLine(list.Find(v => v > 1));

    }

    public delegate Mammals HandlerMethod();
		
    public static Mammals MammalsHandler()
    {
        return null;
    }
		
    public static Dogs DogsHandler()
    {
        return null;
    }
    
    class  FileProcessor
    {
        public delegate void FileProcessedDelegate(string fileName);

        public void ProcessFile(string fileName,FileProcessedDelegate callback)
        {
            // Simulating file processing
            Console.WriteLine("Processing file: " + fileName);
            // ...

            // File processing completed
            callback(fileName);
        }
    }

    static void FileProcessingCompleted(string fileName)
    {
        Console.WriteLine("File processed: " + fileName);
    }

    public class Mammals {}

    public class Dogs : Mammals {}

    public static void DelegateMethod(string message)
    {
        Console.WriteLine($"Hello From static Method : {message} ");
    }

    public static class MethodClass
    {
        public static void Method1(string message) 
        { System.Console.WriteLine($"Hello From First Method : {message}"); }

        public static void Method2(string message) 
        { System.Console.WriteLine($"Hello From Second Method : {message}"); }
    }

    static void Add(int num)
    {
        Console.WriteLine("Adding 5: " + (num + 5));
    }

    static void Subtract(int num)
    {
        Console.WriteLine("Subtracting 3: " + (num - 3));
    }

    static void Multiply(int num)
    {
        Console.WriteLine("Multiplying by 2: " + (num * 2));
    }


    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

delegate void Delegate (string message);

delegate int  CalculationDelegate(int a, int b);

delegate void MathOperationDelegate(int num);

delegate void PrintDelegate(string message);