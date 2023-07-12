
using System.Diagnostics;
using System.Formats.Tar;

public delegate void Del(string message);

namespace Delegates
{
    public static class Program
    {
        // -------------------------------------------HELLO From Threads---------------------------------------------

        // public  static void Main(string[] args)
        // {
        //     Console.WriteLine(Environment.CurrentManagedThreadId);
        //     
        //     var thread = new Thread(UzoqVaqtOladiganMetod)
        //     {
        //         IsBackground = false
        //     };
        //     thread.Start();
        //     
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Main Method sanayapti : {i}");
        //     }
        // }
        //
        // static void UzoqVaqtOladiganMetod()
        // {
        //     
        //     while (true)
        //     {
        //         Thread.Sleep(12000);
        //         Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //         Console.WriteLine("Uzoq vaqt oladigan metodini ichidagi thread id "+
        //                           Environment.CurrentManagedThreadId);
        //         Console.WriteLine("Uzoq vaqt oladigan metod ishladi");
        //     }
        // }

        // -----------------------------------Multiple Threads-------------------------------------------------------

        // public  static void Main(string[] args)
        // {
        //     Console.WriteLine("Mainga kirish va uning idisi");
        //     Console.WriteLine(Environment.CurrentManagedThreadId);
        //     var thread1 = new Thread(AbadiyMetod)
        //     {
        //         Name = "Thread1"
        //     };
        //     var thread2 = new Thread(AbadiyMetod)
        //     {
        //         Name = "Thread2"
        //     };
        //     
        //     thread1.Start();
        //     thread2.Start();
        //     
        //     Console.WriteLine("Maindan chiqish");
        // }
        //
        // public static void AbadiyMetod()
        // {
        //     while (true)
        //     {
        //         Thread.Sleep(5000);
        //         Console.WriteLine("Hozirgi thread id : "+ Thread.CurrentThread.ManagedThreadId);
        //         Console.WriteLine("Hozirgi Thread holati : " + Thread.CurrentThread.ThreadState);
        //         Console.WriteLine("Hozirgi Thread Name : " + Thread.CurrentThread.Name);
        //         Console.WriteLine("Prioriteti :" + Thread.CurrentThread.Priority);
        //         Thread.Sleep(5000);
        //     }
        // }


        // public async static Task Main(string[] args)
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         var thread = new Thread (DifferentMethod);
        //         thread.Start(i);
        //     }
        // }

        // public static void DifferentMethod(object id)
        // {
        //     while(true)
        //         Console.WriteLine("Hello From Another Thread :{0}", id);
        // }

        //-------------------------------------------Background Threads va ForeGraound Threads------------------------------------
        // public async static Task Main(string[] args)
        // {
        //     System.Console.WriteLine(Environment.MachineName);
        //     System.Console.WriteLine(Environment.CurrentManagedThreadId);

        //     for (int i = 0; i < Environment.ProcessorCount; i++)
        //     {
        //         var thread = new Thread(DifferentMethod)
        //         {
        //             IsBackground = true
        //         };

        //         thread.Start(i);
        //     }

        //     Console.WriteLine("Leaving Main");
        // }

        // public static void DifferentMethod(object id)
        // {
        //     while(true)
        //         Console.WriteLine("Hello From Another Thread :{0}", Environment.CurrentManagedThreadId);
        // }

        // -----------------------------------Thread Synchronization ------------------------------------------------------
        // static int count = 0;
        // public  static void Main(string[] args)
        // {
        //    
        //     var thread1 = new Thread(IncrementCount);
        //     var thread2 = new Thread(IncrementCount);
        //     thread1.Start(); 
        //     Thread.Sleep(500);
        //     thread2.Start();
        //     System.Console.WriteLine("Hello From Main Thread : {0}",Environment.CurrentManagedThreadId);
        // }
        //
        // public static void IncrementCount ()
        // {
        //     while(true)
        //     {
        //          Console.WriteLine(count);
        //          int temp = count;
        //          Thread.Sleep(1000);
        //          count = temp + 1;
        //          Console.WriteLine("Current Thread Id : {0}", Environment.CurrentManagedThreadId);
        //          Console.WriteLine("The count is : {0}", count);
        //     }
        // }

        //------------------------------------Basic Thread Synchronization-----------------------------------------
        // static int count = 0;
        // static object baton = new();
        // public static void Main(string[] args)
        // {
        //     var thread1 = new Thread(Increment);
        //     var thread2 = new Thread(Decrement);
        //     
        //     thread1.Start();
        //     thread2.Start();
        //     
        //     thread1.Join();
        //     thread2.Join();
        //     
        //     Console.WriteLine("Hello From Main Thread : {0}", Environment.CurrentManagedThreadId);
        //     Console.WriteLine(GetCount());
        //     
        // }
        //
        // // public static void IncrementCount()
        // // {
        // //     while (true)
        // //     {
        // //         // Only One Thread can come in
        // //         lock (new object())
        // //         {
        // //             Thread.Sleep(1000);
        // //             count++;
        // //             Console.WriteLine("Current Thread Id : {0}", Environment.CurrentManagedThreadId);
        // //             Console.WriteLine("The count is : {0}", count);
        // //         }   
        // //
        // //         Thread.Sleep(1000);
        // //     }
        // // }
        //
        //
        // private static readonly object lockObject = new object();
        //
        // public static void Increment()
        // {
        //     Monitor.Enter(lockObject);
        //     try
        //     {
        //         count++;
        //         Console.WriteLine(count);
        //         Console.WriteLine(Environment.CurrentManagedThreadId + " Increment ");
        //         
        //     }
        //     finally
        //     {
        //       Monitor.Exit(lockObject);  
        //     }
        // }
        //
        // public static void Decrement()
        // {
        //     Monitor.Enter(lockObject);
        //     try
        //     {
        //         count--;
        //         Console.WriteLine(count);
        //         Console.WriteLine(Environment.CurrentManagedThreadId + " Decrement ");
        //     }
        //     finally
        //     {
        //         Monitor.Exit(lockObject);
        //     }
        // }
        //
        // public static int GetCount()
        // {
        //     Monitor.Enter(lockObject);
        //     try
        //     {
        //         return count;
        //     }
        //     finally
        //     {
        //         Monitor.Exit(lockObject);
        //     }
        // }

        // -----------------------------Another Thread Synchronization Example----------------------------------------
        // static object baton = new();
        // static Random random= new();
        // public static void Main(string[] args)
        // {
        //     for (int i = 0; i < 5; i++)
        //     {
        //         new Thread(UseRestroomStall).Start();
        //     }
        // }
        //
        // static void UseRestroomStall()
        // {
        //     Console.WriteLine(Environment.CurrentManagedThreadId +
        //                          "trying to obtain the bathroom stall....");
        //     
        //     lock(baton)
        //     {
        //         Console.WriteLine(Environment.CurrentManagedThreadId +
        //         "obtained the lock .Doing my business.....");
        //
        //         Thread.Sleep(random.Next(2000));
        //
        //         Console.WriteLine(Environment.CurrentManagedThreadId +
        //        "Leaving the stall.....");
        //     }
        //     
        //     Console.WriteLine(Environment.CurrentManagedThreadId + "Leaved the method!!!!!!!");
        // }
        
        // A semaphore that simulates a limited resource pool.
        //
        // private static Semaphore _pool;
        //
        // // A padding interval to make the output more orderly.
        // private static int _padding;
        //
        // public static void Main()
        // {
        //     // Create a semaphore that can satisfy up to three
        //     // concurrent requests. Use an initial count of zero,
        //     // so that the entire semaphore count is initially
        //     // owned by the main program thread.
        //     //
        //     _pool = new Semaphore(initialCount: 0, maximumCount: 3);
        //
        //     // Create and start five numbered threads. 
        //     //
        //     for(int i = 1; i <= 6; i++)
        //     {
        //         Thread t = new Thread(Worker);
        //
        //         // Start the thread, passing the number.
        //         //
        //         t.Start(i);
        //     }
        //
        //     // Wait for half a second, to allow all the
        //     // threads to start and to block on the semaphore.
        //     //
        //     Thread.Sleep(500);
        //
        //     // The main thread starts out holding the entire
        //     // semaphore count. Calling Release(3) brings the 
        //     // semaphore count back to its maximum value, and
        //     // allows the waiting threads to enter the semaphore,
        //     // up to three at a time.
        //     //
        //     Console.WriteLine("Main thread calls Release(3).");
        //     _pool.Release(releaseCount: 3);
        //
        //     Console.WriteLine("Main thread exits.");
        // }
        //
        // private static void Worker(object num)
        // {
        //     // Each worker thread begins by requesting the
        //     // semaphore.
        //     Console.WriteLine("Thread {0} begins " +
        //         "and waits for the semaphore.", num);
        //     _pool.WaitOne();
        //
        //     // A padding interval to make the output more orderly.
        //     int padding = Interlocked.Add(ref _padding, 100);
        //
        //     Console.WriteLine("Thread {0} enters the semaphore.", num);
        //     
        //     // The thread's "work" consists of sleeping for 
        //     // about a second. Each thread "works" a little 
        //     // longer, just to make the output more orderly.
        //     //
        //     Thread.Sleep(1000 + padding);
        //
        //     Console.WriteLine("Thread {0} releases the semaphore.", num);
        //     Console.WriteLine("Thread {0} previous semaphore count: {1}",
        //         num, _pool.Release());
        // }
        
        //--------------------ThreadPoool---------------------------------------------------------
        // public delegate void WaitCallback(object? state);
        //
        // public static void Main()
        // {
        //     List<string> urls = new(){
        //         "https://www.google.com/",
        //         "https://www.duckduckgo.com/",
        //         "https://www.yahoo.com/",
        //         "https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0"
        //     };
        //
        //     foreach (var url in urls)
        //     {
        //         //ThreadPool.QueueUserWorkItem((state) => CheckHttpStatus(url));
        //         //ThreadPool.QueueUserWorkItem((state) => AnotherMethod());
        //     }
        //
        //     for (int i = 0; i < 100; i++)
        //     {
        //         ThreadPool.QueueUserWorkItem((state) => AnotherMethod());
        //     }
        //     
        //     
        //     Console.Read();
        // }
        // static void CheckHttpStatus(string url)
        // {
        //     HttpClient client = new();
        //     var response = client.GetAsync(url).Result;
        //     Console.WriteLine($"The HTTP status code of {url} is {response.StatusCode}");
        //     Console.WriteLine(Environment.CurrentManagedThreadId);
        //
        // }
        //
        // static void AnotherMethod()
        // {
        //     Console.WriteLine(" Its Free Thread from ThreadPool on Another Method : \n" +   Environment.CurrentManagedThreadId);
        // }
        
        // public static void Main() 
        // {
        //     // Queue the task.
        //     ThreadPool.QueueUserWorkItem(ThreadProc);
        //     Console.WriteLine("Main thread does some work, then sleeps.");
        //     Thread.Sleep(1000);
        //
        //     Console.WriteLine("Main thread exits.");
        // }
        //
        // // This thread procedure performs the task.
        // static void ThreadProc(Object stateInfo) 
        // {
        //     // No state object was passed to QueueUserWorkItem, so stateInfo is null.
        //     Console.WriteLine("Hello from the thread pool.");
        // }
        
        
        // public static void Main()
        // {
        //     // Queue the task.
        //     ThreadPool.QueueUserWorkItem(ThreadPoolMethod);
        //     Console.WriteLine("Main thread starts");
        //     Thread.Sleep(1000);		
        //     Console.WriteLine("Main thread exits.");
        //     Console.ReadKey();
        // }
        //
        // static void ThreadPoolMethod(Object stateInfo)
        // {
        //     Console.WriteLine("Hello from the thread pool.");
        // }

        // static void Main(string[] args)
        // {
        //     Stopwatch mywatch = new ();
        //
        //     Console.WriteLine("Thread Pool Execution");
        //
        //     mywatch.Start();
        //     ProcessWithThreadPoolMethod();
        //     mywatch.Stop();
        //
        //     Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
        //     mywatch.Reset();
        //
        //
        //     Console.WriteLine("Thread Execution");
        //
        //     mywatch.Start();
        //     ProcessWithThreadMethod();
        //     mywatch.Stop();
        //
        //     Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        // }
        //
        // static void ProcessWithThreadPoolMethod()
        // {
        //     for (int i = 0; i <= 10; i++)
        //     {
        //         ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
        //     }
        // }
        //
        // static void ProcessWithThreadMethod()
        // {
        //     for (int i = 0; i <= 10; i++)
        //     {
        //         Thread obj = new Thread(Process);
        //         obj.Start();
        //     }
        // }
        //
        // static void Process(object callback)
        // {
        //
        // }
    }

}
