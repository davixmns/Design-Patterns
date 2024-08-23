namespace Design_Patterns.Mediator;

public class User : ColleagueUser
{
    public User(IFacebookGroupMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} : enviada => {message}");
        Mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} : recebida <= {message}");
    }
}