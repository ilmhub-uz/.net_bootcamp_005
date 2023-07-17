namespace OOP.Abstraction.Abstract_Key_Word;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Vauv Vauv");
    }

    public override void Sleep()
    {
        Console.WriteLine("Dogs sleeps sometimes.");
    }
}