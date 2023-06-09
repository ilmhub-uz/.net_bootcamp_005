//----------------Funksiyalar ---------------

public enum Languages
{
        Uz,
        Uzc,
        Ru,
}


public enum Colors
{
	None = 0,
	Red = 1,
	Blue = 2,
	Green = 4,
	Yellow = Red | Green,
	Purple = Red | Blue,
	Cyan = Blue | Green,
	White = Red | Blue | Green
}

public enum DaysOfWeek
{
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
	Sunday = 7
}


public enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    Delete = 8
}

   // Define an Enum without FlagsAttribute.
   enum SingleHue : short
   {
      None = 0,
      Black = 1,
      Red = 2,
      Green = 3,
      Blue = 4
   };

   
   [Flags]
   enum MultiHue : short
   {
      None = 0,
      Black = 1,
      Red = 2,
      Green = 3,
      Blue = 4
   };

    public static class Program
    {
        public static  void  EkrangaChiqar(string parametr)
        {
            Console.WriteLine(parametr);
        }

        public static void ArrayniToldir(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }
        }

        public static int Qoshish(int a, int b)
        {
        return a + b;
        }

        public static void Salomlash(int yosh, string ism = "Samandar")
        {
            Console.WriteLine($"Salom {ism} tanishganimdan hursandaman,men ham {yosh} yoshdaman.");
        }

        public static int Factorial(int n)
            => n == 0 ? 1 : n * Factorial(n - 1);

         static async Task Main(string[] args)
        {
        //var array = new int[10];
        //ArrayniToldir(array);
        //EkrangaChiqar("Salom");
        //Salomlash(25);
        //Console.WriteLine(Qoshish(3,4));
        //Console.WriteLine(Factorial(Qoshish(3, 4)));

        // Value tayplani reference tayp qilib jo'natish uchun ref kalit so'zidan foydalanamiz

        //void ModifyValue(ref string value,out int yosh)
        //{
        //    value = "Salom";
        //    yosh = 25;
        //    Console.WriteLine(value);
        //    Console.WriteLine(yosh);
        //}

        //string number = string.Empty;
        //int yosh ;
        //ModifyValue(ref number,out yosh);
        //Console.WriteLine(number);
        //Console.WriteLine(yosh);

        //// Out kalit so'zi

        //void GetValues( out int a, out  int b)
        //{
        //    a = 10;

        //    b = 20;
        //}

        //int x , y ;
        //GetValues(out x, out y);
        //Console.WriteLine( $"X ning qiymati : {x} va Y ning qiymati : {y}" );

        // In kalit so'zi
        //void PrintValue(in int value, in string data)
        //{
        //    // 'value' o'zgartirish mumkin emas
        //    // value = 10;
        //    Console.WriteLine(value);
        //    Console.WriteLine(data);
        //}

        //PrintValue(5,"Salom");

        //void PrintNumbers(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var number in numbers)
        //    {
        //        sum+= number;
        //        Console.WriteLine(number);
        //    }

        //    Console.WriteLine(sum);
        //}

        //PrintNumbers(1, 2, 3);     // Output: 1 2 3
        //PrintNumbers(4, 5, 6, 7);  // Output: 4 5 6 7
        //PrintNumbers(8); // Output: 8
        //var emtyArray = Array.Empty<int>();
        //PrintNumbers();

        //--------------------- Enumlar --------------------


        //var day = DaysOfWeek.Monday;
        //Console.WriteLine(day);

        //string dayString = "Seshanba";
        //DaysOfWeek parsedDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayString);
        //Console.WriteLine(parsedDay);

        //DaysOfWeek day = DaysOfWeek.Monday;
        //Console.WriteLine(day);

        //string dayString = "Tues";

        //Enum.TryParse(typeof(DaysOfWeek), dayString,true,out var parsedDay);
        //Console.WriteLine(parsedDay); // Output: Tuesday

        // Enumni qiymatini olish
        //Array enumValues = Enum.GetValues(typeof(DaysOfWeek));

        //foreach (DaysOfWeek value in enumValues)
        //{
        // Console.WriteLine(value);
        //    Console.WriteLine(value.GetType());
        //}

        //string[] enumNames = Enum.GetNames(typeof(DaysOfWeek));
        //foreach (string name in enumNames)
        //{
        // Console.WriteLine(name);
        //    Console.WriteLine(name.GetType());
        //}

        //Colors selectedColors = Colors.Red | Colors.Blue;
        //Console.WriteLine(selectedColors.HasFlag(Colors.Red)); // Output: True
        //Console.WriteLine(selectedColors.HasFlag(Colors.Green)); // Output: False

        //Permissions userPermissions = Permissions.Read | Permissions.Write;
        //Console.WriteLine(userPermissions.HasFlag(Permissions.Read)); // Output: True

        //Console.WriteLine(
        //"All possible combinations of values without FlagsAttribute:");
        //   for(int val = 0; val <= 16; val++ )
        //      Console.WriteLine( "{0,3} - {1:G}", val, (SingleHue)val);

        //   // Display all combinations of values, and invalid values.
        //   Console.WriteLine(
        //        "\nAll possible combinations of values with FlagsAttribute:");
        //   for( int val = 0; val <= 16; val++ )
        //      Console.WriteLine( "{0,3} - {1:G}", val, (MultiHue)val);

        //SingleHue singleHue = SingleHue.Black & SingleHue.Red;
        //MultiHue multiHue = MultiHue.Black & MultiHue.Red;

        //Console.WriteLine("Enum without Flags attribute:");
        //Console.WriteLine(singleHue); // Output: Black, Red

        //Console.WriteLine("\nEnum with Flags attribute:");
        //Console.WriteLine(multiHue); // Output: Black, Red

        //Console.WriteLine("\nIndividual values in Enum with Flags attribute:");
        //foreach (MultiHue hue in Enum.GetValues(typeof(MultiHue)))
        //{
        //    Console.WriteLine($"{hue} - {(int)hue}");
        //}

            //Console.WriteLine(Divide(10, 2));
      
            

            //int Divide(int a, int b)
            //{
            //    //try
            //    //{
            //    //    throw new ArgumentException("Argument exception");
            //    //    // Connect to database
            //    //    //Connection to Server
            //    //    //Writing Files to disk
            //    //    //Reading files from disk
                    
            //    //}
            //    //catch (ArgumentException)
            //    //{
            //    //    return 0;
            //    //}
            //    //catch (DivideByZeroException)
            //    //{
            //    //  return 0;
            //    //}
            //    //catch (Exception)
            //    //{
            //    //    Console.WriteLine();
            //    //    return 0;
            //    //}
            //    //finally
            //    //{
            //    //    Console.WriteLine("Finally");
            //    //    // Idisposable dan Dispose () metodini chaqirish
            //    //    // Garbage collector ishga tushirish
            //    //}
	            
            //    try
            //    {
            //        throw new NullReferenceException();
            //    }
            //    catch(Exception e) when(e is NullReferenceException || e is ArgumentNullException
            //    || e is DivideByZeroException)
            //    {
            //        Console.WriteLine("Tabrikliyman Null ushab oldiz !!!!");
            //    }
            //}

        }

        
    }


