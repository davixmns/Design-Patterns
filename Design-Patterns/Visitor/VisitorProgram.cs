namespace Design_Patterns.Visitor;

public class VisitorProgram
{
    public static void Run()
    {
        List<IElement> cars = [
            new Car { Name = "Audi", Price = 450_000 },
            new Car { Name = "BMW", Price = 670_000 },
            new Car { Name = "Lamborghini", Price = 1_000_000 }
        ];
        
        PriceVisitor priceVisitor = new(10);
         
        foreach (var car in cars)
        {
            car.Accept(priceVisitor);
        }
    }
}