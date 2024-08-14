namespace Design_Patterns.Facade;

public class CreditLimit
{
    public bool HaveCreditLimit(Client client, double value)
    {
        Console.WriteLine($"Verifying if {client.Name} has credit limit...");

        return !(value > 200000.00);
    }
}