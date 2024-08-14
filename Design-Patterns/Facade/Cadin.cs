namespace Design_Patterns.Facade;

public class Cadin
{
    public bool IsInCadin(Client client)
    {
        Console.WriteLine($"Verifying if {client.Name} is in Cadin...");
        return new Random().Next(0, 2) == 1;
    }
}