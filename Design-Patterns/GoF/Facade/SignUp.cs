namespace Design_Patterns.GoF.Facade;

public class SignUp
{
    public void SignUpClient(Client client)
    {
        Console.WriteLine($"{client.Name} signed up successfully!");
    }
}