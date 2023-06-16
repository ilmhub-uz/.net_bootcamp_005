namespace Dars_8;

public class NolYokidaNullException : Exception
{
    public NolYokidaNullException(string message)
    {
        Message = message;
        Chiqar();
    }

    public string Message { get; set; }

    public void Chiqar()
    {
        Console.WriteLine(Message);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.White;
    }
}
