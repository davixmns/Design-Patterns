namespace Design_Patterns.Visitor;

//Concrete Element
public class Car : IElement
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}