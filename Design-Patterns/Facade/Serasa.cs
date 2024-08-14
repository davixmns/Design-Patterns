namespace Design_Patterns.Facade;

public class Serasa
{
    public bool IsInSerasa(Client client)
    {
        Console.WriteLine($"Verifying if {client.Name} is in SERASA...");
        return new Random().Next(0, 2) == 1;
    }
}