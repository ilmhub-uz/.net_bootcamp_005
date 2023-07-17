namespace OOP.Encapsulation;

public class AtmMachine
{
    private string _customerName;
    private string _accountNumber;
    private decimal _totalCashInAtm;

    public string ShowCustomerName
    {
        get { return _customerName; }
    }
}