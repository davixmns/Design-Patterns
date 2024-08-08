using Design_Patterns.GoF.Observer.Interfaces;

namespace Design_Patterns.GoF.Observer;

public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = [];

    private string ProductName { get; set; }
    private bool Availability { get; set; }

    public ConcreteSubject(string productName, bool availability)
    {
        ProductName = productName;
        Availability = availability;
    }

    public void SetAvailability(bool availability)
    {
        if (Availability == availability) return;
        
        Availability = availability;
        
        Notify();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);

        Console.WriteLine($"Observer {observer} was attached");
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);

        Console.WriteLine($"Observer {observer} was detached");
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(Availability, ProductName);
        }

        Console.WriteLine("Observers notified!");
    }
}