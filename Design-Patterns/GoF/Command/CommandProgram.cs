namespace Design_Patterns.GoF.Command;

public class CommandProgram
{
    public static void Execute()
    {
        //Receiver
        var chef = new Chef();
        
        //Concrete Command 1
        var order1 = new Order(chef, "appetizer");
        
        //Invoker
        var waiter = new Waiter(order1);
        waiter.TakeOrder();
        
        //Concrete Command 2
        var order2 = new Order(chef, "main course");
         
        waiter.PlaceOrder(order2);
        
        waiter.TakeOrder();
    }
}