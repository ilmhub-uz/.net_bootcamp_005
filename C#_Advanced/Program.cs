namespace C__Advanced;

static class Program
{
    static void Main(string[] args)
    {
        //Button button = new ();
        //Subscriber subscriber = new ();
        //subscriber.Subscribe(button);
        //button.OnClick();

        //Publisher publisher = new ();
        //Subscriber subscriber = new ();
        //subscriber.Subscribe(publisher);
        //publisher.KonpkaniBosdiniUygot();

        Counter c = new (new Random().Next(10));
        c.ThresholdReached += CThresholdReached;
        Console.WriteLine("press 'a' key to increase total");

        while (Console.ReadKey(true).KeyChar == 'a')
        {
            Console.WriteLine("adding one");
            c.Add(1);
        }

        static void CThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", 
                e.Threshold,e.TimeReached);
            Environment.Exit(0);
        }
    }
}

class Counter
{
    private readonly int _threshold;
    private int _total;

    public Counter(int passedThreshold)
    {
        _threshold = passedThreshold;
    }

    public void Add(int x)
    {
        _total += x;
        if (_total < _threshold)
        {
            return;
        }

        ThresholdReachedEventArgs args = new ()
        {
            Threshold = _threshold,
            TimeReached = DateTime.Now
        };
        OnThresholdReached(args);
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
        EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
        handler?.Invoke(this, e);
    }

    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
}

public class ThresholdReachedEventArgs : EventArgs
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
}
/*
 * 1.Next
2.Counter ni konstruktori
3.Console.WriteLine
4 Console.ReadKey(true)
5 Console.WriteLine
6 ADD
7 n marta ReadKey bilan WriteLine
8 OnThresholdReached
9 Invoke()
10 CThresholdReached
11 WriteLine
12 Exit
 */
class Button
{
    public event EventHandler Click;
    
    public void OnClick()
    {
        //var d = new object(){};
        Click(this, EventArgs.Empty);
        //Click.Invoke(d,EventArgs.Empty);
    }
}

class Subscriber
{
    //public void Subscribe(Button button)
    //{
    //    button.Click += ButtonBosildi;
    //}

    public void Subscribe(Publisher publisher)
    {
        publisher.SampleEvent += ButtonBosildi;
    }
    
    public void ButtonBosildi(object sender, SampleEventArgs e)
    {
        Console.WriteLine($"Jo'natuvchi {sender} va Qabul qiluvchi {this} kelgan parametr  {e.GetType()} va Text {e.Text}");
        Console.WriteLine("Konpka bosildi!");
    }

}

public class SampleEventArgs : EventArgs
{
    public SampleEventArgs(string text) { Text = text; }
    public string Text { get; } 
}

public class Publisher
{
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);
        
    public event SampleEventHandler SampleEvent;

    public void KonpkaniBosdiniUygot()
    {
        SampleEvent?.Invoke(this, new SampleEventArgs("Default Qiymat"));
    }
}