namespace Design_Patterns.Decorator.Implementation_2;

public class DiscountDecorator : Decorator
{
    private double _discountPercentage;
    
    public DiscountDecorator(IComponent componentBase, double discountPercentage) : base(componentBase)
    {
        _discountPercentage = discountPercentage;
    }

    public override double CalculatePrice()
    {
        double originalPrice = base.CalculatePrice();
        double discountAmount = originalPrice * _discountPercentage;
        return originalPrice - discountAmount;
    }
}