namespace Design_Patterns.GoF.Command;

//Invoker
public class Waiter
{
    private Order _order;
    
    public Waiter(Order order)
    {
        _order = order;
    }
    
    public void TakeOrder()
    {
        _order.Execute();
    }
    
    public void PlaceOrder(Order order)
    {
        _order = order;
    }
}