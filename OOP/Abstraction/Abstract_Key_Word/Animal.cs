namespace OOP.Abstraction.Abstract_Key_Word;

public abstract class Animal
{
    public abstract void MakeSound();

    public virtual void Sleep()
    {
        Console.WriteLine("This animal do not sleep at all !!!!");
    }
}