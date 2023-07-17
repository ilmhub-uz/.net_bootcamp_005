//-------------------- Looplar -----------------------------
// 1 start
// 2 step
// 3 stop

//char start = '@';

//while (true)
//{
//    start++;

//    if (start == 'W') continue;

//    Console.WriteLine(start);

//    if(start == 'Z')  break;

//}

//int son = 100;
//do
//{
//    Console.WriteLine(son);

//} while (son < 10);

//for (int s = 1; s <= 10; s++)
//{
//    Console.WriteLine();
//}

//// Generate a random number
//var rnd = new Random ();
//var secretNumber = rnd.Next(1,10);

//var lifeCount = 3;

//int numberGuessed;

//Console.WriteLine($"Random Num : {secretNumber} ");
//do
//{
//    Console.Write("Enter a number between 1 & 10 : ");
//    int.TryParse(Console.ReadLine(),out numberGuessed);

//    if (secretNumber == numberGuessed)
//    {
//        Console.WriteLine("You guessed it is was {0}",secretNumber);
//        break;
//    }

//    lifeCount--;

//    if (lifeCount == 0)
//    {
//        Console.WriteLine("Game Over !!!");
//        break;
//    }

//}while (true);

//int [] numbers = new [] { 1, 2, 3, 4, 5,6 };
//var oddNumbers = new List<int>();

//foreach (var number in numbers)
//{
//    if (number % 2 != 0)
//    {
//        oddNumbers.Add(number);
//        Console.WriteLine(number);
//    }
//}

//for (int i = 0; i < 10; i++)
//{
//    var random = new Random();
//    // 1 va 100 oralig'ida raqam generatsiya qilish
//    var son = random.NextSingle();
//    Console.WriteLine(son);

//    // Random random = new Random();
//    // //0.0 va 1.0 orasidagi qoldiqli son
//    // double randomDouble = random.NextDouble();
//    // Console.WriteLine(randomDouble);
//}

//var arraycha = new int [10];

//Toldir(arraycha);
//// Aralashtir(arraycha);
//EkrangaChiqar(arraycha);

////var parol = ParolYasabBer(16);
////Console.WriteLine(parol);

//void Aralashtir(int[] raqamlar)
//{
//    Random random = new Random(100);

//    for (int hozirgiIndex = raqamlar.Length - 1; hozirgiIndex > 0; hozirgiIndex--)
//    {
//        int tasodifiyIndex = random.Next(hozirgiIndex + 1);
//        int vaqtinchalikIdish = raqamlar[hozirgiIndex];
//        raqamlar[hozirgiIndex] =raqamlar[tasodifiyIndex];
//        raqamlar[tasodifiyIndex] = vaqtinchalikIdish;
//    }
//}

//void EkrangaChiqar(int [] raqamlar)
//{
//    foreach (int raqam in raqamlar)
//    {
//        Console.WriteLine(raqam);
//    }
//}

//string ParolYasabBer(int parolUzunligi)
//{
//    const string ehtimoliyHarflar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

//    var parol = string.Empty;

//    var random = new Random();

//    for (var startIndex = 0; startIndex < parolUzunligi; startIndex++)
//    {
//        var index = random.Next(ehtimoliyHarflar.Length-1);
//        parol += ehtimoliyHarflar[index];
//    }

//    return parol;
//}

//void Toldir (int[] raqamlar)
//{
//    var random = new Random();

//    for (var hozirgiIndex = 0; hozirgiIndex < raqamlar.Length; hozirgiIndex ++)
//    {
//        raqamlar[hozirgiIndex] = random.Next(raqamlar.Length-1);
//    }
//}

//int a = int.MaxValue;
//int b = 1;

//checked
//{
//    // Overflow exception otadi
//    int result = a + b;
//    Console.WriteLine(result);
//}
//unchecked
//{
//    // Overflow otilmaydi keyingi oraliqqa o'tadi.
//    int result = a + b;
//    Console.WriteLine(result);
//}

//unsafe
//{
//    //var someVariable = 0;
//    //int* ptr = &someVariable; // Unsafe pointer operation
//    //*ptr = 10; // Assigning a value through a pointer
//    //Console.WriteLine(someVariable);
//    int number = 42;
//    Console.WriteLine(number);                   // Output: "42"
//    Console.WriteLine(new IntPtr(&number));      // Output: "<memory address>"
//}
static void Main(string[] args)
{
    Console.WriteLine("Hello World");
}