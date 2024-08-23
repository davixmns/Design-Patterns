namespace Design_Patterns.Mediator;

public class FacebookGroupMediator : IFacebookGroupMediator
{
    private List<ColleagueUser> _users = [];
    
    public void SendMessage(string message, ColleagueUser sender)
    {
        foreach (var user in _users.Where(user => user != sender))
        {
            user.Receive(message);
        }
    }

    public void RegisterUser(ColleagueUser colleagueUser)
    {
        _users.Add(colleagueUser);
    }
}