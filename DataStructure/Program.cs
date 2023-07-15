using System.Diagnostics;

public static  class Program
{
    static string[] names ={
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"};
    
    public static void Main()
    {
        // Queue<int> numbers = new Queue<int>();
        // numbers.Enqueue(1);
        // numbers.Enqueue(2);
        // numbers.Enqueue(3);
        // numbers.Enqueue(4);
        // numbers.Enqueue(5);
        //
        // Console.WriteLine("Original Queue: " + string.Join(", ", numbers));
        //
        // // Remove element at index 2 (value 3) from the middle.
        // RemoveFromMiddle(numbers, 2);
        //
        // Console.WriteLine("Modified Queue: " + string.Join(", ", numbers));
        
        // Stack<int> numbers = new Stack<int>();
        // numbers.Push(1);
        // numbers.Push(2);
        // numbers.Push(3);
        // numbers.Push(4);
        // numbers.Push(5);
        //
        // Console.WriteLine("Original Stack: " + string.Join(", ", numbers));
        //
        // // Remove element at index 2 (value 3) from the middle.
        // RemoveFromMiddle(numbers, 2);
        //
        // Console.WriteLine("Modified Stack: " + string.Join(", ", numbers));
        
        // string[] names = new string[] {
        //     "mahesh",
        //     "vikram",
        //     "mahesh",
        //     "mayur",
        //     "suprotim",
        //     "saket",
        //     "manish"
        // };
        //
        // HashSet<string> set = new (names);
        //
        // foreach (string item in set)
        // {
        //     Console.WriteLine(item);
        // }
        
        // HashSet<string> colors = new () { "red", "green", "blue" };
        // colors.Remove("green");
        // Console.WriteLine(string.Join(", ", colors)); // Output: red, blue
        
        // HashSet<string> fruits = new () { "apple", "orange", "banana" };
        // bool containsApple = fruits.Contains("apple"); // true
        // bool containsGrapes = fruits.Contains("grapes"); // false
        
        // HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        // HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };
        // set1.UnionWith(set2);
        // Console.WriteLine(string.Join(", ", set1)); // Output: 1, 2, 3, 4, 5
        
        // HashSet<int> set1 = new () { 1, 2, 3 };
        // HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };
        // set1.UnionWith(set2);
        // Console.WriteLine(string.Join(", ", set1)); // Output: 1, 2, 3, 4, 5
        //
        // HashSet<int> setA = new HashSet<int>() { 1, 2, 3 };
        // HashSet<int> setB = new HashSet<int>() { 2, 3, 4 };
        // setA.IntersectWith(setB);
        // Console.WriteLine(string.Join(", ", setA)); // Output: 2, 3
        
        // HashSet<int> setX = new HashSet<int>() { 1, 2, 3 };
        // HashSet<int> setY = new HashSet<int>() { 3, 4, 5 };
        // setX.ExceptWith(setY);
        // Console.WriteLine(string.Join(", ", setX)); // Output: 1, 2
        
        
        // Console.WriteLine("____________________________________");
        // Console.WriteLine("List Performance while Adding Item");
        // Console.WriteLine();
        //
        // List< string > lstNames = new List< string >();
        //
        // var s2 = Stopwatch.StartNew();
        //
        // foreach (string s in names)
        // {
        //     lstNames.Add(s);
        // }
        // s2.Stop();
        //
        // Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
        // Console.WriteLine();
        // Console.WriteLine("Ends Here");
        // Console.WriteLine();
        // Console.WriteLine("____________________________________");
        // Console.WriteLine("HashSet Performance while Adding Item");
        // Console.WriteLine();
        //
        // HashSet< string > hStringNames = new (StringComparer.Ordinal);
        // var s1 = Stopwatch.StartNew();
        // foreach (string s in names)
        // {
        //     hStringNames.Add(s);
        // }
        // s1.Stop();
        //
        // Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));Console.WriteLine();
        // Console.WriteLine("Ends Here");
        // Console.WriteLine("____________________________________");
        // Console.WriteLine();
        
        // Dictionary<int, string> ages = new ();
        // ages[0] = "25";
        // ages.Add(1,"Plus");
        // ages.Add(int.MaxValue,string.Empty);
        // ages[7] = "";
        
        // Dictionary<string, int> scores = new Dictionary<string, int>()
        // {
        //     { "Math", 95 },
        //     { "Science", 88 },
        //     { "History", 78 }
        // };
        //
        // scores.Remove("Science");
        
        // Dictionary<string, string> capitals = new Dictionary<string, string>()
        // {
        //     { "USA", "Washington, D.C." },
        //     { "UK", "London" },
        //     { "France", "Paris" }
        // };
        //
        // bool hasUSA = capitals.ContainsKey("USA"); // true
        // bool hasGermany = capitals.ContainsKey("Germany"); // false
        //
        // Console.WriteLine(hasGermany);
        // Console.WriteLine(hasUSA);
        //
        // foreach (KeyValuePair<string, string> pair in capitals)
        // {
        //     Console.WriteLine(pair.Key + ": " + pair.Value);
        // }
        
        
        // Dictionary<string, int> population = new Dictionary<string, int>()
        // {
        //     { "USA", 331002651 },
        //     { "India", 1380004385 },
        //     { "Brazil", 212559417 }
        // };
        //
        // if (population.TryGetValue("India", out int indiaPopulation))
        // {
        //     Console.WriteLine($"Population of India: {indiaPopulation}");
        // }
        // else
        // {
        //     Console.WriteLine("India not found in the dictionary.");
        // }
        
        // Dictionary<string, double> prices = new Dictionary<string, double>()
        // {
        //     { "Apple", 0.99 },
        //     { "Banana", 0.59 },
        //     { "Orange", 0.79 }
        // };
        //
        // foreach (var key in prices.Keys)
        // {
        //     Console.WriteLine($"Price of {key}: ${prices[key]}");
        // }
        
        // Queue<string> queue = new ();
        //
        // queue.Enqueue("apple");
        // queue.Enqueue("banana");
        // queue.Enqueue("orange");
        //
        // foreach (var element in queue)
        // {
        //     Console.WriteLine(element);
        // }
        // queue.Dequeue();
        // queue.Clear();
        
        // Behruz  3
        // Queue<string> queue = new ();
        //
        // queue.Enqueue ("apple");
        // queue.Enqueue ("banana");
        // queue.Enqueue ("stowbary");
        // queue.Enqueue ("kivy");
        // queue.Enqueue ("apricos");
        // queue.Enqueue ("orange");
        //
        // foreach (var item in queue)
        // {
        //     Console.WriteLine (item);
        // }
        //
        // Console.WriteLine ("enter index of number which you are  going to remove:");
        //
        // int.TryParse(Console.ReadLine(),out int number);
        //
        // try
        // {
        //     ToRemoveQueue(queue, number);
        // }
        // catch(Exception ex)
        // {
        //     Console.WriteLine("An error occured: " + ex.Message);
        // }
        //
        // static void ToRemoveQueue(Queue<string>queue, int index)
        // {
        //     List<string> list = new List<string>(queue);
        //
        //     if (index > 0 && index < list.Count)
        //     {
        //         list.RemoveAt(index);
        //     }
        //     else
        //     {
        //         throw new Exception("smth is unusualy");
        //     }
        //
        //     queue = new Queue<string>(list);
        //
        //     foreach (var item in queue)
        //     {
        //         Console.WriteLine(item);
        //     }
        // }
        
        //TemurMalik Bahosi 4 3 ta list hisobiga
        // Random random = new Random();
        // var q = new Queue<int>();
        // int len = 10;
        // for (int i = 0; i < len; i++)
        // {
        //     q.Enqueue(random.Next(1, 100));
        // }
        // try
        // {
        //     int index = int.Parse(Console.ReadLine()!);
        //     
        //     Console.WriteLine(q.ToList()[index]); // 1 list
        //     //Console.WriteLine(q.GetType());
        //     var list = q.ToList(); //2 list
        //     list.RemoveAt(index);
        //     q.Clear();
        //     for (int i = 0; i < list.Count; i++)
        //     {
        //         q.Enqueue(list[i]);
        //     }
        //     
        //     q.ToList().ForEach(x => Console.WriteLine(x)); //3 ta list
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        
        // 2
        // Random random = new Random();
        // var q = new Queue<int>();
        // int len = 10;
        // for (int i = 0; i < len; i++)
        // {
        //     q.Enqueue(random.Next(1, 100));
        // }
        // q.ToList().ForEach(x => Console.WriteLine(x));
        //
        // Console.WriteLine("-------------------------------------");
        // try
        // {
        //     int index = int.Parse(Console.ReadLine()!);
        //     if (index < 0 || index > q.Count - 1) throw new Exception();
        //     int i = 0;
        //     while (i != index)
        //     {
        //         int number = q.Dequeue();
        //         q.Enqueue(number);
        //         ++i;
        //     }
        //     q.Dequeue();
        //     q.ToList().ForEach(x => Console.WriteLine(x));
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        
        // Anvar 3 second 3 ta loop  2 ta queue 5 baho
        // var timer = new Stopwatch();
        // timer.Start();
        // Queue<string> origin = new (); //2 ta queue
        //
        // origin.Enqueue ("a");
        // origin.Enqueue ("b");
        // origin.Enqueue ("c");
        // origin.Enqueue ("d");
        // origin.Enqueue ("e");
        // origin.Enqueue ("f");
        // origin.Enqueue ("e");
        // origin.Enqueue ("f");
        // origin.Enqueue ("e");
        // origin.Enqueue ("f");
        //
        // foreach (var item in origin)
        // {
        //     Console.WriteLine(item);
        // }
        // RemoveFromMiddle(origin,5);
        //
        // timer.Stop();
        // Console.WriteLine(timer.ElapsedMilliseconds.ToString("0.00 ms"));

        // static void RemoveFromMiddle(Queue<string> origin,int c)
        // {
        //    int a = origin.Count;
        //    Queue<string> copy = new();
        //    
        //    for (int i = 1; i < a + 1; i++) //1
        //    {
        //        if (i == c) { string b = origin.Dequeue(); }
        //    
        //        else {
        //            string b = origin.Dequeue();
        //            copy.Enqueue(b);
        //        }
        //    }
        //    
        //    origin.Clear(); //2
        // }
        
        
        // Numon  1 ta que 1 ta array 7 secund bahosi 5 
        // var timer = new Stopwatch();
        // timer.Start();
        // var queue = new Queue<int>();
        //     queue.Enqueue(1);
        //     queue.Enqueue(2);
        //     queue.Enqueue(3);
        //     queue.Enqueue(4);
        //     queue.Enqueue(5);
        //     queue.Enqueue(6);
        //     queue.Enqueue(7);
        //     queue.Enqueue(8);
        //     queue.Enqueue(9);
        //     queue.Enqueue(10);
        //
        // RemoveCenter(5, queue);
        // foreach(int i in queue)
        //     Console.WriteLine(i);
        //
        // timer.Stop();
        // Console.WriteLine(timer.ElapsedMilliseconds.ToString("0.00ms"));
        //
        // void RemoveCenter<T>(int index, Queue<T> queue)
        // {
        //     if(index < 0 || index >= queue.Count) throw new IndexOutOfRangeException();
        //
        //     T[] array = new T[queue.Count];
        //     queue.CopyTo(array, 0); 
        //     queue.Clear(); 
        //     for(int i = 0; i < array.Length; i++) 
        //     {
        //         if(i == index) continue; 
        //         queue.Enqueue(array[i]);
        //     }
        // }
    }

   
}