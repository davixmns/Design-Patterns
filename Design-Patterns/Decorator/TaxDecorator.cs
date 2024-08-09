namespace Design_Patterns.Decorator;

public class TaxDecorator : Decorator
{
    private double _taxPercentage;
    
    public TaxDecorator(IComponent componentBase, double taxPercentage) : base(componentBase)
    {
        _taxPercentage = taxPercentage;
    }

    public override double CalculatePrice()
    {
        var basePrice = base.CalculatePrice();
        var taxAmount = basePrice * _taxPercentage;
        return basePrice + taxAmount;
    }
}