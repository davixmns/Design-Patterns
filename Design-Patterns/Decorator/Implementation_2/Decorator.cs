namespace Design_Patterns.Decorator.Implementation_2;

public abstract class Decorator : IComponent
{
    protected IComponent ComponentBase;

    protected Decorator(IComponent componentBase)
    {
        ComponentBase = componentBase;
    }
    
    public virtual double CalculatePrice()
    {
        return ComponentBase.CalculatePrice();
    }
}