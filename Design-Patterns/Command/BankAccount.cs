namespace Design_Patterns.Command;

//Receiver
public class BankAccount
{
    public string Number { get; private set; }
    public decimal InitialBalance { get; private set; }
    
    public BankAccount(string number, decimal initialBalance)
    {
        Number = number;
        InitialBalance = initialBalance;
    }
    
    public void Deposit(decimal amount)
    {
        InitialBalance += amount;
        Console.WriteLine($"Deposited {amount}, balance is now {InitialBalance}");
    }
    
    public void Withdraw(decimal amount)
    {
        if (InitialBalance >= amount)
        {
            InitialBalance -= amount;
            Console.WriteLine($"Withdrew {amount}, balance is now {InitialBalance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}