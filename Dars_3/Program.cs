//--------------------------Array------------------------------------------------

//// 3 ta qiymatni saqlaydigan arrayni e'lon qilish
//int [] favNums = new int[30];

//// yangi array yasab uni to'ldirib ketish
//string[] customers = { "Bob", "Sally", "Sue","hghggh" };

//// Arrayning qiymatlari bir xil tipda bo'lishi kerak
//var employees = new[] { "Mike", "Paul", "Rick" };

//// Obyekt array yasash orqali istalgan tipni berish
//object[] randomArray = { "Paul", 45, 1.234 };

//foreach (var item in randomArray)
//{
//    Console.WriteLine(item);
//    var type = item.GetType();
//    Console.WriteLine(type);

//}

//// Qiymat berish
//favNums[0] = 23;

//// Qiymatni qaytarib chiqarish
//Console.WriteLine("favNum 0 : {0}", favNums[0]);

//// Get Type orqali tipini aniqlash mumkin
//Console.WriteLine("randomArray 0 : {0}",
//    randomArray[0].GetType());

//// Arraydagi elementlarni sonini chiqarish
//Console.WriteLine("Array Size : {0}",
//    randomArray.Length);

//// For loop orqali arrayni elementlarini chiqarish
//for (int j = 0; j < randomArray.Length; j++)
//{
//    Console.WriteLine("Array {0} : Value : {1}",
//        j, randomArray[j]);
//}

//using System.Collections;

//int[] numbers = { 10, 20, 30, 40, 50 };

//Console.WriteLine(numbers[^1]);  // Output: 50 (oxirgi element)
//Console.WriteLine(numbers[^2]);  // Output: 40 (oxiridan sanaganda 2 chi element)
//Console.WriteLine(numbers[^3]);  // Output: 30 (oxiridan sanaganda element)

//// Array elementlarini ^ index orqali o'zgartitsh
//numbers[^1] = 60;  // eng oxirgi elementi  60 ga o'zgartiradi
//Console.WriteLine(numbers[^1]);  // Rezultat: 60

//// Arrayning elementlarini ^ index orqali qirqib olish
//// eng oxiridigi elementni va oxiridan 3 chisidi element bilan
//// birga qirqib olib yangi arrayga soladi.

//int[] slicedNumbers = numbers[^3..^1];

//foreach (int number in slicedNumbers)
//{
//    Console.WriteLine(number);  // Output: 30, 40
//}

// foreach For loop orqali arrayni chiqarsa bo'ladi
//int[] randNums = { 1, 4, 9, 2 };

// Arrayni Sortirovka qiberadi
//Array.Sort(randNums);

//PrintArray(randNums);

//// Arrayni teskarisiga o'giradi
//Array.Reverse(randNums);

// Arrayni orasidan qidirish agar topilmasa -1 qaytaradi.
//Console.WriteLine("1 at index : {0} ",
//    Array.IndexOf(randNums, 100));

//PrintArray(randNums);

//// 1 index dagi qiymatni 0 ga o'zgartiradi
//randNums.SetValue(3,1);
//Array.Fill(randNums ,5);
//PrintArray(randNums);

//// Bitta arraydan ikkinchi arrayga malum qismini ko'piyalash
//int[] srcArray = { 1, 2, 3, 4 };
////int[] destArray = new int[srcArray.Length];

////Array.Copy(srcArray,destArray,destArray.Length);

////PrintArray(destArray);

////// CreateInstance orqali yengi array yasash
//var anotherArray = new int[10];

////// 5 indexdan boshlab ikkinchi arrayga ko'piyasini oladi.
//srcArray.CopyTo(anotherArray, 5);

//void PrintArray(int[] ints)
//{
//    foreach (var item in ints)
//    {
//        Console.WriteLine(item);
//    }
//}

// 2 o'lchamli arraylar odatda qator va ustunlarni belgilsh uchun ishlatiladi.
// agar siz [2,2] deb array elon qilsangiz unda 2 ta ustun 2 ta qator bo'ladi.

//int[,] matrix = new int[3, 4]
//{
//    { 1, 2, 3, 4 },
//    { 5, 6, 7, 8 },
//    { 9, 10, 11, 12 }
//};

//// Elementlarini olish
//int element = matrix[1,2];  //1 qator, 2 ustun (qiymat : 7)
//Console.WriteLine(element); // Rezultat: 7
//int counter = 0;
//foreach (var variable in matrix)
//{
//    if (counter == 3)
//    {
//        Console.WriteLine();
//        counter = 0;
//    }
//    Console.Write(variable + " ");
//    counter++;
//}

//string[,] custNames = new string[2, 2] { { "Bob", "Smith" },
//    { "Sally", "Smith" } };

//// 2D arrayda qiymatni olish
//Console.WriteLine("MD Value : {0}",
//    custNames.GetValue(1, 1));

////2D arrayda loop ishlatish uchun bizaga qator uzunligi va ustun uzunligi kerak bo'ladi
//for (int j = 0; j < custNames.GetLength(0); j++)
//{
//    // Get length of multidimensional array row
//    for (int k = 0; k < custNames.GetLength(1); k++)
//    {
//        Console.Write("{0} ", custNames[j, k]);
//    }
//    Console.WriteLine();
//}

//var stringArray = Console.ReadLine()?.Split(' ',',');

//foreach (var VARIABLE in stringArray)
//{
//    Console.WriteLine(VARIABLE);
//}

//// An array like arrName[2,2,3] would be like a
//// stack of 3 spread sheets with 2 rows and 2
//// columns worth of data on each page

//// foreach can be used to cycle through an array
//int[] randNums = { 1, 4, 9, 2 };

//// You can pass an array to a function
//PrintArray(randNums);

//// Sort array
//Array.Sort(randNums);

//// Reverse array
//Array.Reverse(randNums);

//// Get index of match or return -1
//Console.WriteLine("1 at index : {0} ",
//    Array.IndexOf(randNums, 1));

//// Change value at index 1 to 0
//randNums.SetValue(0, 1);

//// Copy part of an array to another
//int[] srcArray = { 1, 2, 3 };
//int[] destArray = new int[2];
//int startInd = 0;
//int length = 2;

//Array.Copy(srcArray, startInd, destArray,
//    startInd, length);

//PrintArray(destArray, "Copy");

//// Create an array with CreateInstance
//Array anotherArray = Array.CreateInstance(typeof(int), 10);

//// Copy values in srcArray to destArray starting
//// at index 5 in destination
//srcArray.CopyTo(anotherArray, 5);

//foreach (int m in anotherArray)
//{
//    Console.WriteLine("CopyTo : {0} ", m);
//}

//// Jagged array ni elon qilish
//int[][] jaggedArray;

//// Jagged array ga hajim berish.
//jaggedArray = new int[3][];

//// Ichidagi har bitta arrayni alohida elon qilish
//jaggedArray[0] = new int[2] { 1, 2 };
//jaggedArray[1] = new int[3] { 3, 4, 5 };
//jaggedArray[2] = new int[4] { 6, 7, 8, 9 };

//ArrayList fruits = new ArrayList
//{
//    "Apple",
//    "Banana",
//    "Orange"
//};

//// AddRange orqali bir nechta elementi baravar qo'shish
//fruits.AddRange(new string[] { "Mango", "Grapes" });

//foreach (var fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}