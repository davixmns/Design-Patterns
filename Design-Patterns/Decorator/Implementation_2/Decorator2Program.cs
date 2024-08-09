namespace Design_Patterns.Decorator.Implementation_2;

public class Decorator2Program
{
    public static void Run()
    {
        IComponent productBase = new ConcreteComponent();
        Console.WriteLine($"Product base price: {productBase.CalculatePrice()}");
        
        IComponent productWithTax = new TaxDecorator(productBase, 0.2);
        Console.WriteLine($"Product with tax price: {productWithTax.CalculatePrice()}");

        IComponent productWithDiscount = new DiscountDecorator(productBase, 0.1);
        Console.WriteLine($"Product with discount price: {productWithDiscount.CalculatePrice()}");
        
        
        IComponent productWithDiscountAndTax = new TaxDecorator(productWithDiscount, 0.2);
        Console.WriteLine($"Product with discount and tax price: {productWithDiscountAndTax.CalculatePrice()}");
    }
}