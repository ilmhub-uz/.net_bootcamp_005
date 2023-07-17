namespace OOP.Abstraction.Abstract_Key_Word;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Miav Miav");
    }

    public override void Sleep()
    {
        Console.WriteLine("Cat always sleeps.");
    }
}