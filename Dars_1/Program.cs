// Komentariyalar Kompilator tomonidan ko'rib chiqilmaydi va shunchaki ignore qilinadi.

/*
Bu bir nechta qatorda komentariya yozishning yo'li bo'lib bunday komentariyalarni
siz boshqa dasturchiga yozib qoldirasiz.
*/

///<summary>
/// XMl komentariyalar API larga dokumentatsiya yozishda
/// Metodlarga dokumentatsiya yozishda qo'llaniladi.
/// </summary>

//---------------------Console bilan ishlash -----------------------------------

Console.Write(" Birinchi habar."); //Bitta qatorga yozadi yangi qator tashamaydi.

Console.WriteLine("Ikkinchi habar."); // Yangi qatorga yozadi .

Console.Read(); //Bitta harfni o’qib oladi.

Console.ReadLine(); // Bitta qatordagi to’liq matni o’qib oladi.

Console.ReadKey();// Klaviaturani istalgan key ini o’qib oladi.

Console.Clear(); // Kansoldagi istalgan malumotni tozalab yuboradi.


// --------------------Data Typelar------------------------------------------

//----------------Butun sonlar uchun data typelar -----------------------------
Console.WriteLine("Byte ning eng katta qiymati.");
Console.WriteLine(byte.MaxValue);
Console.WriteLine("Byte ning eng kichkina qiymati :");
Console.WriteLine(byte.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(byte));
Console.WriteLine("***************************************************************");
Console.WriteLine("short ning eng katta qiymati.");
Console.WriteLine(short.MaxValue);
Console.WriteLine("short ning eng kichkina qiymati :");
Console.WriteLine(short.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(short));
Console.WriteLine("***************************************************************");
Console.WriteLine("Int ning eng katta qiymati.");
Console.WriteLine(int.MaxValue);
Console.WriteLine("Int ning eng kichkina qiymati :");
Console.WriteLine(int.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(int));
Console.WriteLine("***************************************************************");
Console.WriteLine("long ning eng katta qiymati.");
Console.WriteLine(long.MaxValue);
Console.WriteLine("long ning eng kichkina qiymati :");
Console.WriteLine(long.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(long));
Console.WriteLine("***************************************************************");
/*Har qanday butun sonni qabul qiladigan datatype
 oldiga 'u' belgisi qo'yish orqali uni minus son olmaydigan qilib qo'yamiz*/
Console.WriteLine("ulong ning eng katta qiymati.");
Console.WriteLine(ulong.MaxValue);
Console.WriteLine("ulong ning eng kichkina qiymati :");
Console.WriteLine(ulong.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(ulong));
Console.WriteLine("***************************************************************");

//--------------------Qoldiqli sonlar ----------------------------------------------------
Console.WriteLine("double ning eng katta qiymati.");
Console.WriteLine(double.MaxValue);
Console.WriteLine("double ning eng kichkina qiymati :");
Console.WriteLine(double.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(double));
Console.WriteLine("***************************************************************");
Console.WriteLine("float ning eng katta qiymati.");
Console.WriteLine(float.MaxValue);
Console.WriteLine("float ning eng kichkina qiymati :");
Console.WriteLine(float.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(float));
Console.WriteLine("***************************************************************");
Console.WriteLine("decimal ning eng katta qiymati.");
Console.WriteLine(decimal.MaxValue);
Console.WriteLine("decimal ning eng kichkina qiymati :");
Console.WriteLine(decimal.MinValue);
Console.WriteLine("Hotiradan oladigan joyi byte larda");
Console.WriteLine(sizeof(decimal));
Console.WriteLine("***************************************************************");
/*
 Eslatma qoldiqli sonlarni qabul qiladigan data typelar oldiga u belgisini qo'yib bo'lmaydi .
 Decimal nuqatadan keyingi aniqlik 28 ta xona pulli hisob kitoblarga ishlatiladi.
 Double  nuqtadan keyingi aniqlik 14 ta xona ilmiy hisob kitoblarga ishlatiladi.
 Float nuqtadan keyingi aniqlik  6 ta xona .
 */

// Char Bitta harfni yoki belgini saqlaydi.
Console.WriteLine("char ni Hotiradan oladigan joyi byte larda :");
Console.WriteLine(sizeof(char));
char harf = 'A';
Console.WriteLine(harf);

Console.WriteLine("Boolean ni hotiradan oladigan joyi.");
Console.WriteLine(sizeof(bool));
bool rostYokiYolgon = true;
Console.WriteLine(rostYokiYolgon);

string text = "Istalgan uzunlikdagi tekstni oladi va u o'zgarmasdur";
Console.WriteLine(text);
Console.WriteLine("Yuqoridagi matning uzunligi.");
Console.WriteLine(text.Length);
