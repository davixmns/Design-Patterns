namespace Design_Patterns.Mediator;

public class MediatorProgram
{
    public static void Run()
    {
        var facebookGroupMediator = new FacebookGroupMediator();
        
        ColleagueUser david = new User(facebookGroupMediator, "David");
        ColleagueUser john = new User(facebookGroupMediator, "John");
        ColleagueUser lisa = new User(facebookGroupMediator, "Lisa");
        
        facebookGroupMediator.RegisterUser(david);
        facebookGroupMediator.RegisterUser(john);
        facebookGroupMediator.RegisterUser(lisa);
        
        david.Send("Hello everyone!");
    }
}