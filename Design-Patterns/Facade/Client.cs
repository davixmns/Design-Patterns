namespace Design_Patterns.Facade;

public class Client
{
    public string Name { get; set; } = string.Empty;
    
    public Client(string name)
    {
        Name = name;
    }
}