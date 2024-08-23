namespace Design_Patterns.Mediator;

public interface IFacebookGroupMediator
{
    void SendMessage(string message, ColleagueUser colleagueUser);
    void RegisterUser(ColleagueUser colleagueUser);
}