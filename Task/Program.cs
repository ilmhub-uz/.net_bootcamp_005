﻿// var thread = new Thread(() => Console.WriteLine("Hello from Thread"));
// thread.Start();
//
// Task.Run(() => Console.WriteLine("Hello from Task"));

//Delegate Action<T> variable name action
// Action<object> action = (object obj) =>
// {
//     Console.WriteLine("Task={0}, obj={1}, Thread={2}",
//         Task.CurrentId, obj,
//         Thread.CurrentThread.ManagedThreadId);
// };
//
// // Create a task but do not start it.
// Task t1 = new Task(action, "alpha");
//
// // Construct a started task
// Task t2 = Task.Factory.StartNew(action, "beta");
// // Block the main thread to demonstrate that t2 is executing
// t2.Wait(1200);
//
// // Launch t1 
// t1.Start();
// Console.WriteLine("t1 has been launched. (Main Thread={0})",
//     Thread.CurrentThread.ManagedThreadId);
// // Wait for the task to finish.
// t1.Wait();
//
// // Construct a started task using Task.Run.
// String taskData = "delta";
// Task t3 = Task.Run( () => {Console.WriteLine("Task={0}, obj={1}, Thread={2}",
//     Task.CurrentId, taskData,
//     Thread.CurrentThread.ManagedThreadId);
// });
// // Wait for the task to finish.
// t3.Wait();
//
// // Construct an unstarted task
// Task t4 = new Task(action, "gamma");
// // Run it synchronously
// t4.RunSynchronously();
// // Although the task was run synchronously, it is a good practice
// // to wait for it in the event exceptions were thrown by the task.
// t4.Wait();

 // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
    // internal class Bacon { }
    // internal class Coffee { }
    // internal class Egg { }
    // internal class Juice { }
    // internal class Toast { }
    //
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         
    //     }
    //
    //     private static Juice PourOJ()
    //     {
    //         Console.WriteLine("Pouring orange juice");
    //         return new Juice();
    //     }
    //
    //     private static void ApplyJam(Toast toast) =>
    //         Console.WriteLine("Putting jam on the toast");
    //
    //     private static void ApplyButter(Toast toast) =>
    //         Console.WriteLine("Putting butter on the toast");
    //
    //     private static Toast ToastBread(int slices)
    //     {
    //         for (int slice = 0; slice < slices; slice++)
    //         {
    //             Console.WriteLine("Putting a slice of bread in the toaster");
    //         }
    //         Console.WriteLine("Start toasting...");
    //         Console.WriteLine("Remove toast from toaster");
    //
    //         return new Toast();
    //     }
    //
    //     private static Bacon FryBacon(int slices)
    //     {
    //         Console.WriteLine($"putting {slices} slices of bacon in the pan");
    //         Console.WriteLine("cooking first side of bacon...");
    //         for (int slice = 0; slice < slices; slice++)
    //         {
    //             Console.WriteLine("flipping a slice of bacon");
    //         }
    //         Console.WriteLine("cooking the second side of bacon...");
    //         Console.WriteLine("Put bacon on plate");
    //
    //         return new Bacon();
    //     }
    //
    //     private static Egg FryEggs(int howMany)
    //     {
    //         Console.WriteLine("Warming the egg pan...");
    //         Console.WriteLine($"cracking {howMany} eggs");
    //         Console.WriteLine("cooking the eggs ...");
    //         Console.WriteLine("Put eggs on plate");
    //
    //         return new Egg();
    //     }
    //
    //     private static Coffee PourCoffee()
    //     {
    //         Console.WriteLine("Pouring coffee");
    //         return new Coffee();
    //     }
    // }

// var t1 = new Task(UyqudanTurish);
// var t2 = new Task(Yuvunish);
// var t3 = new Task(ChoyTayyorlash);
//
// t2.Start();
// t1.Start();
// t3.Start();
//
// var allTask = Task.WhenAll(t1,t2,t3);
// allTask.Wait();
//
// static void UyqudanTurish()
// {
//     Console.WriteLine("Uyqudan Turdim");
//     Console.WriteLine("Yuvingani Kettim.");
// }
//
// static void Yuvunish()
// {
//     Task.Delay(1500).Wait();
//     Console.WriteLine("Yuzimni yuvdim.");
//     Console.WriteLine("Tishimni yuvdim");
//     Console.WriteLine("Nonushtaga kettim");
// }
//
// static void ChoyTayyorlash()
// {
//     Task.Delay(3000).Wait();
//     Console.WriteLine("Cofe Tayyorladim.");
//     Console.WriteLine("Tuxum Qovurdim");
//     Console.WriteLine("Ovqatlandim");
//}


/// <summary>
/// DeadLock
/// </summary>
// OddiyMethod();
// 
// static Task OddiyMethod()
// {
//     Console.WriteLine("Method 1 ishladi ");
//     var t3 = UchinchiMethod();
//     if(t3.IsCompleted)
//         BoshqaMethod();
//     Console.WriteLine("Method 1 tugadi");
//     return Task.CompletedTask;
// }
//
// static Task BoshqaMethod()
// {
//     Console.WriteLine("Method 2 ishladi");
//     return Task.CompletedTask;
// }
//
// static Task UchinchiMethod()
// {
//     Console.WriteLine("Method 3 ishladi");
//     var t1 = OddiyMethod();
//     return Task.CompletedTask;
// }

/// <summary>
/// Race Condition
/// </summary>
// public static class Program
// {
//     static int count  = 0; 
//     static void Main()
//     {
//         Task t1 = new Task(Oshir);
//         var t2 = new Task(Kamaytir);
//         var t3 = new Task(Bol);

//         t1.Start();
//         t2.Start();
//         t3.Start();

//         Console.WriteLine(t3.IsCompletedSuccessfully);
//         Console.WriteLine(t3.Exception);
//         Console.Read();
//     }
//
//     static void Oshir()
//     {
//         count++;
//         Console.WriteLine(count);
//     }
//
//     static void Kamaytir()
//     {
//         count--;
//         Console.WriteLine(count);
//     }
//
//     static void Bol()
//     {
//         count /= count;
//         Console.WriteLine(count);
//     }
// }

public class Program
{
   public static readonly List<User> users = new ()
   {
       new ("Samandar",19),
       new ("Olmos",19),
       new ("TemurMalik",19),
       new ("Numon",19),
       new ("Ergash",26),
       new ("Anvar",19),
   };

   static  async Task  Main()
   {
       var result = GetUserAsync("Ergash").Result;
       var resultWithAwait = await GetUserAsync("Olmos");
       var taskResult = GetUserAsync("Numon");
       
       Console.WriteLine(result);
       Console.WriteLine(resultWithAwait);
       Console.WriteLine(taskResult);
   }
   
   static  Task<User> GetUserAsync(string name)
       => Task.FromResult(users.FirstOrDefault(s => s.Name == name ) ?? new User("", 0));
}

public record User(string Name,int Age);

