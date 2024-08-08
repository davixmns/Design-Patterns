using Design_Patterns.GoF.Observer.Interfaces;

namespace Design_Patterns.GoF.Observer;

public class ConcreteObserver : IObserver
{
    private string UserName { get; set; }

    public ConcreteObserver(string userName)
    {
        UserName = userName;
    }

    public void Update(bool availability, string productName)
    {
        Console.WriteLine($"Hello {UserName}, {productName} is now" +
                          $" {(availability ? "available" : "not available")}");
    }

    public override string ToString()
    {
        return UserName;
    }
}