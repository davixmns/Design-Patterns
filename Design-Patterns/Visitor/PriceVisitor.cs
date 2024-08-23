namespace Design_Patterns.Visitor;

//Concrete Visitor
public class PriceVisitor : IVisitor
{
    private readonly int _carDiscount;
    
    public PriceVisitor(int carDiscount)
    {
        _carDiscount = carDiscount;
    }
    
    public void Visit(Car car)
    {
        decimal carPriceWithDiscount = car.Price - (car.Price * _carDiscount / 100);
        Console.WriteLine($"{car.Name} with discount is ${carPriceWithDiscount}");
    }
}