namespace Design_Patterns.Decorator;

public class ConcreteComponent : IComponent
{
    public double CalculatePrice()
    {
        var price = 10.0;
        return price;
    }
}