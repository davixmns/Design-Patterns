namespace Design_Patterns.GoF.Facade;

public class MyFacade
{
    private CreditLimit _limit;
    private Serasa _serasa;
    private Cadin _cadin;
    private SignUp _signUp;
    
    public MyFacade()
    {
        _limit = new CreditLimit();
        _serasa = new Serasa();
        _cadin = new Cadin();
        _signUp = new SignUp();
    }
    
    public bool GrantLoan(Client client, double value)
    {
        Console.WriteLine($"{client.Name} is requesting a loan of {value:C}...");
        
        _signUp.SignUpClient(client);

        if (_serasa.IsInSerasa(client))
        {
            Console.WriteLine($"{client.Name} is in SERASA. Loan denied.");
            return false;
        }
        
        if (_cadin.IsInCadin(client))
        {
            Console.WriteLine($"{client.Name} is in CADIN. Loan denied.");
            return false;
        }

        if (!_limit.HaveCreditLimit(client, value))
        {
            Console.WriteLine($"{client.Name} has no credit limit. Loan denied.");
            return false;
        }

        return true;
    }
}