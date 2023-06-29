namespace OOP.Encapsulation;

public class BankAccount
{
    private  decimal _balance; // private field

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
