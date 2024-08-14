namespace Design_Patterns.Facade;

public class SignUp
{
    public void SignUpClient(Client client)
    {
        Console.WriteLine($"{client.Name} signed up successfully!");
    }
}