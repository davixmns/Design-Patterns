namespace Design_Patterns.GoF.Observer.Interfaces;

public interface IObserver
{
    void Update(bool availability, string productName);
}