namespace Design_Patterns.Observer;

public interface IObserver
{
    void Update(bool availability, string productName);
}