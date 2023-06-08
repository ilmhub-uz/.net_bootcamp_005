    //----------------Funksiyalar ---------------

    public enum Languages
    {
        Uz,
        Uzc,
        Ru,
    }

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
        }

        
    }


