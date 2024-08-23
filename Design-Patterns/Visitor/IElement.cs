namespace Design_Patterns.Visitor;

//Element Interface
public interface IElement
{
    void Accept(IVisitor visitor);
}