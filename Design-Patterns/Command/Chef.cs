namespace Design_Patterns.GoF.Command;

//Receiver
public class Chef
{
    public void CookAppetizer()
    {
        System.Console.WriteLine("Chef is preparing appetizer");
    }
    
    public void CookMainCourse()
    {
        System.Console.WriteLine("Chef is preparing main course");
    }
    
    public void CookDessert()
    {
        System.Console.WriteLine("Chef is preparing dessert");
    }
}