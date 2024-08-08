namespace Design_Patterns.GoF.Command;

//Concrete Command
public class Order : Command
{
    private Chef _chef { get; set; }
    private string _action { get; set; }
    
    public Order(Chef chef, string action)
    {
        _chef = chef;
        _action = action;
    }
    
    public override void Execute()
    {
        switch (_action)
        {
            case "appetizer":
                _chef.CookAppetizer();
                break;
            case "main course":
                _chef.CookMainCourse();
                break;
            case "dessert":
                _chef.CookDessert();
                break;
        }
    }
}