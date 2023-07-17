
// //(double, int) t1 = (4.5, 3);
// //Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

// //(double Sum, int Count) t2 = (4.5, 3);
// //Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

// //(double, int) t = (4.5, 3);
// //Console.WriteLine(t +" "+ t.GetType() +" " + t.Item1.GetType()  + " "+ t.Item2.GetType());
// //Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");
// ////t.Item1 = 1;
// //Tuple<string> t3 = new("Salom" );
// //Console.WriteLine(t.GetType() + "and" + t3.GetType());
// ////t3.Item1 = "something";

// //var xs = new [] { 4, 7, 9,0,-96,1023 };
// //var limits = FindMinMax(xs);
// //if(!string.IsNullOrEmpty(limits.errorMessage))
// //        Console.WriteLine(limits.errorMessage);

// //Console.WriteLine($"{string.Join(" ", xs)} the min number is {limits.min} and the max number is {limits.max}");



// //(int min, int max,string errorMessage) FindMinMax(int[]? input)
// //{
// //    if (input is null || input.Length == 0)
// //    {
// //        return (0,0,"Pustoy Array yoki null keldi");
// //    }

// //    var min = int.MaxValue;

// //    var max = int.MinValue;

// //    foreach (var i in input)
// //    {
// //       min =  i < min ?  i : min;
// //       max = i > max ? i : max;
// //    }
// //    return (min, max,string.Empty);
// //}

// //var t = (Summa: 4.5, Schetchik: 3);
// //Console.WriteLine($"Sum of {t.Schetchik} elements is {t.Summa}.");

// //(double Sum, int Count) d = (4.5, 1000000);
// //Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

// //var sum = 4.5;
// //var count = 3;
// //var t = (sum, count);
// //Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");

// //var a = 1;
// //var t = (a, b: 2, c:3);
// //Console.WriteLine($"The 1st element is {t.Item1} (same as {t.a}).");
// //Console.WriteLine($"The 2nd element is {t.Item2} (same as {t.b}).");
// //Console.WriteLine($"The 3rd element is {t.Item3} (same as {t.c}).");

// //(double a, string b) left = (5, "10");
// //(int c, string d) right = (5, "10");
// //Console.WriteLine(left == right);  // output: True
// //Console.WriteLine(left != right);  // output: False

// //Console.WriteLine((3,40) == (Display(3), Display(40)));

// //int Display(int s)
// //{
// //    Console.WriteLine(s);
// //    return s;
// //}

// //var t = ("post office", 3.6, 4.0);
// //var (destination, distance,nimadur) = t;
// //Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

// //var anonim = new { Age = 12,Name = "Tom",Price = 123,Color = "Blue"};
// //Console.WriteLine(anonim.ToString() + "\n" + anonim.GetType());

// // Func<int, int> square = x => x * x;
// // int result = square(5);
// // Console.WriteLine(result);

// // Func<int, int, int> add = (x, y) => x + y;
// // int result = add(3, 4);
// // Console.WriteLine(result);// result = 7

// // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
// //
// // List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

// // var person = new Person("Samandar", "Aliyev");
// // Console.WriteLine(person);
// // Console.WriteLine(person.ToString());

// // Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
// // var numbers = (2, 3, 4);
// // var doubledNumbers = doubleThem(numbers);
// // Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");

// using System.Linq.Expressions;

// int[] numbers = { 2, 3, 4, 5 };
// var squaredNumbers = numbers.Select(x => x * x);
// Console.WriteLine(string.Join(" ", squaredNumbers));

// var parse = (string s) => int.Parse(s);

// object parse3 = (string s) => int.Parse(s);   // Func<string, int>
// Delegate parse4 = (string s) => int.Parse(s); // Func<string, int>

// var read = Console.Read; // Just one overload; Func<int> inferred
// var write = Console.Write; // ERROR: Multiple overloads, can't choose

// LambdaExpression parseExpr = (string s) => int.Parse(s); // Expression<Func<string, int>>
// Expression parseExpr2 = (string s) => int.Parse(s);// Expression<Func<string, int>>

// var parse5 = s => int.Parse(s); // ERROR: Not enough type info in the lambda

// Func<string, int> parse8 = s => int.Parse(s);

// var choose = (bool b) => b ? 1 : "two"; // ERROR: Can't infer return type

// var choose2 = object (bool b) => b ? 1 : "two"; // Func<bool, object>

// Func<double, double> square = static x => x * x;

// public class Person
// {
//     public readonly string _fname;
//     public readonly string _lname;

//     public Person(string lname, string fname)
//     {
//         _lname = lname;
//         _fname = fname;
//     }
//     public override string ToString() => $"{_fname} {_lname}".Trim();
// }


