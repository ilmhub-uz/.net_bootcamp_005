//// Komentariyalar Kompilator tomonidan ko'rib chiqilmaydi va shunchaki ignore qilinadi.

///*
//Bu bir nechta qatorda komentariya yozishning yo'li bo'lib bunday komentariyalarni
//siz boshqa dasturchiga yozib qoldirasiz.
//*/

/////<summary>
///// XMl komentariyalar API larga dokumentatsiya yozishda
///// Metodlarga dokumentatsiya yozishda qo'llaniladi.
///// </summary>

////---------------------Console bilan ishlash -----------------------------------

//Console.Write(" Birinchi habar."); //Bitta qatorga yozadi yangi qator tashamaydi.

//Console.WriteLine("Ikkinchi habar."); // Yangi qatorga yozadi .

//Console.Read(); //Bitta harfni o’qib oladi.

//Console.ReadLine(); // Bitta qatordagi to’liq matni o’qib oladi.

//Console.ReadKey();// Klaviaturani istalgan key ini o’qib oladi.

//Console.Clear(); // Kansoldagi istalgan malumotni tozalab yuboradi.

//// --------------------Data Typelar------------------------------------------

////----------------Butun sonlar uchun data typelar -----------------------------
//Console.WriteLine("Byte ning eng katta qiymati.");
//Console.WriteLine(byte.MaxValue);
//Console.WriteLine("Byte ning eng kichkina qiymati :");
//Console.WriteLine(byte.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(byte));
//Console.WriteLine("***************************************************************");
//Console.WriteLine("short ning eng katta qiymati.");
//Console.WriteLine(short.MaxValue);
//Console.WriteLine("short ning eng kichkina qiymati :");
//Console.WriteLine(short.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(short));
//Console.WriteLine("***************************************************************");
//Console.WriteLine("Int ning eng katta qiymati.");
//Console.WriteLine(int.MaxValue);
//Console.WriteLine("Int ning eng kichkina qiymati :");
//Console.WriteLine(int.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(int));
//Console.WriteLine("***************************************************************");
//Console.WriteLine("long ning eng katta qiymati.");
//Console.WriteLine(long.MaxValue);
//Console.WriteLine("long ning eng kichkina qiymati :");
//Console.WriteLine(long.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(long));
//Console.WriteLine("***************************************************************");
///*Har qanday butun sonni qabul qiladigan datatype
// oldiga 'u' belgisi qo'yish orqali uni minus son olmaydigan qilib qo'yamiz*/
//Console.WriteLine("ulong ning eng katta qiymati.");
//Console.WriteLine(ulong.MaxValue);
//Console.WriteLine("ulong ning eng kichkina qiymati :");
//Console.WriteLine(ulong.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(ulong));
//Console.WriteLine("***************************************************************");

////--------------------Qoldiqli sonlar ----------------------------------------------------
//Console.WriteLine("double ning eng katta qiymati.");
//Console.WriteLine(double.MaxValue);
//Console.WriteLine("double ning eng kichkina qiymati :");
//Console.WriteLine(double.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(double));
//Console.WriteLine("***************************************************************");
//Console.WriteLine("float ning eng katta qiymati.");
//Console.WriteLine(float.MaxValue);
//Console.WriteLine("float ning eng kichkina qiymati :");
//Console.WriteLine(float.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(float));
//Console.WriteLine("***************************************************************");
//Console.WriteLine("decimal ning eng katta qiymati.");
//Console.WriteLine(decimal.MaxValue);
//Console.WriteLine("decimal ning eng kichkina qiymati :");
//Console.WriteLine(decimal.MinValue);
//Console.WriteLine("Hotiradan oladigan joyi byte larda");
//Console.WriteLine(sizeof(decimal));
//Console.WriteLine("***************************************************************");
///*
// Eslatma qoldiqli sonlarni qabul qiladigan data typelar oldiga u belgisini qo'yib bo'lmaydi .
// Decimal nuqatadan keyingi aniqlik 28 ta xona pulli hisob kitoblarga ishlatiladi.
// Double  nuqtadan keyingi aniqlik 14 ta xona ilmiy hisob kitoblarga ishlatiladi.
// Float nuqtadan keyingi aniqlik  6 ta xona .
// */

//// Char Bitta harfni yoki belgini saqlaydi.
//Console.WriteLine("char ni Hotiradan oladigan joyi byte larda :");
//Console.WriteLine(sizeof(char));
//char harf = 'A';
//Console.WriteLine(harf);

//Console.WriteLine("Boolean ni hotiradan oladigan joyi.");
//Console.WriteLine(sizeof(bool));
//bool rostYokiYolgon = true;
//Console.WriteLine(rostYokiYolgon);

//string text = "Istalgan uzunlikdagi tekstni oladi va u o'zgarmasdur";
//Console.WriteLine(text);
//Console.WriteLine("Yuqoridagi matning uzunligi.");
//Console.WriteLine(text.Length);

//--------------------------------Type Casting ---------------------------------------------
//int butunson = 10;
//double qoldiqliSon = butunson;
//Console.WriteLine(qoldiqliSon);

//double son = 10.5;
//int son2 = (int)son;
//Console.WriteLine(son2);

//int num = 10;
//object boxedNum = num;  // Boxing
//int unboxedNum = (int)boxedNum;  // Unboxing

//Console.WriteLine("Butun son kiriting :");
//var number1 = Convert.ToDouble(Console.ReadLine());  // Using Convert.ToInt32 method
//Console.WriteLine(number1);

//var number2 = double.Parse(Console.ReadLine());  // Using Parse method
//Console.WriteLine(number2);

//int raqam;

//int.TryParse(Console.ReadLine(),out raqam);

//Console.WriteLine(raqam);

//string name = "John";
//int age = 30;
//bool isMale = true;
//Console.WriteLine("Name: {0}, Age: {1} isMale : {2}", name, age, isMale);  // Output: Name: John, Age: 30

//string name = "John";
//int age = 30;
//Console.WriteLine($"Name: {name}, Age: {age}");  // Output: Name: John, Age: 30

//double pi = 3.14159;
//Console.WriteLine("Pi: {0:F2}", pi);  // Output: Pi: 3.14

//string path1 = "C:\\MyFolder\\file.txt";        // oddiy string
//string path2 = @"C:\MyFolder\file.txt";          // Verbatim string

//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));  // Output: Current Date: 5/28/2023

// String istalgancha harfdan iborat bo'ladi.

//string randString = "Bu nimadur bo'ldi va tushundik";

//// string uzunligini olish
//Console.WriteLine("String Length : {0}", randString.Length);

//// string ichida boshqa string bor yo'qligini tekshirish
//Console.WriteLine($"String Contains is : {randString.Contains("va")}");

//// Qidirilgan string boshlangan indexi
//Console.WriteLine($"Index of is : {randString.IndexOf("va")}");

//// Ko'rsatilgan miqdorda harifni olib tashlash
//Console.WriteLine("Remove string : {0}",
//    randString.Remove(10, 5));

//Console.WriteLine(randString);

// stringa ko'rsatilgan indexdan boshlab yangi string qo'shish.
//Console.WriteLine("Insert String : {0}",
//    randString.Insert(12, ", "));

// Bitta stringni boshqasi bilan alamshtirish
//Console.WriteLine("Replace String : {0}",
//    randString.Replace("pul", "10000000000"));

// Bitta stringni boshqa stringa taqqoslash
// Agar 0 dan kichik qiymat qaytsa 1 string 2 chisidan Alifboda oldin keladi.
// Agar 0 qaytsa ikkalasi bir xil keladi yani teng.
// Agar 0 dan katta qiymat kesa 1 string 2 sidan kegin turadi Alifbo tartibida.
//string str1 = "Assalom";
//string str2 = "aSSALOM";

//int result = string.Compare(str1, str2);

//if (result < 0)
//{
//    Console.WriteLine(result);
//    Console.WriteLine("{0} comes before {1}", str1, str2);
//}
//else if (result == 0)
//{
//    Console.WriteLine(result);
//    Console.WriteLine("{0} and {1} are equal", str1, str2);
//}
//else
//{
//    Console.WriteLine(result);
//    Console.WriteLine("{0} comes after {1}", str1, str2);
//}

// Ikkita stringni tenglikka tekshiradi.
//Console.WriteLine("A = a : {0}",
//    String.Equals("A", "a"));

// Chapga surish :
//Console.WriteLine(randString.PadLeft(50,'*'));

// O'ngga surish
//Console.WriteLine(randString.Length);
//Console.WriteLine("Pad Right : {0} Stuff",
//    randString.PadRight(20, '-'));

//// stringni oldidagi va oxiridagi hamma bo'sh joylarni olib tashlaydi
//string input = "                Hello, World!                      ";
//string trimmed = input.Trim();

//Console.WriteLine(input);
//Console.WriteLine(trimmed);  // Output: "Hello, World!"

//// Hammasini katta harifga o'zgartiradi.
//Console.WriteLine("Uppercase : {0}",
//    randString.ToUpper());

//// Hammasini kichkina harifga o'zgartiradi.
//Console.WriteLine("Lowercase : {0}",
//    randString.ToLower());

//// Yangi string yasash uchun ishlatiladi.
//string newString = String.Format("{0} saw a {1} {2} in the {3}",
//    "Paul", "rabbit", "eating", "field");

////// \n,\b,\t kabi belgilarni ishlata olasiz.
//Console.Write(newString + "\n");
static void Main(string[] args)
{
    Console.WriteLine("Hello World");
}