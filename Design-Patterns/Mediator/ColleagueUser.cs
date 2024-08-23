namespace Design_Patterns.Mediator;

public abstract class ColleagueUser
{
    protected IFacebookGroupMediator Mediator;
    protected string Name;

    public ColleagueUser(IFacebookGroupMediator mediator, string name)
    {
        Mediator = mediator;
        Name = name;
    }
    
    public abstract void Send(string message);
    
    public abstract void Receive(string message);
}