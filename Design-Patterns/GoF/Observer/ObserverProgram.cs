namespace Design_Patterns.GoF.Observer;

public class ObserverProgram
{
    public static void Execute()
    {
        var subject = new ConcreteSubject("iPhone 15", false);
        
        var observer1 = new ConcreteObserver("Mateus");
        var observer2 = new ConcreteObserver("Marcos");
        var observer3 = new ConcreteObserver("Lucas");
        var observer4 = new ConcreteObserver("João");
        
        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.Attach(observer3);
        subject.Attach(observer4);
        
        subject.SetAvailability(true);
    }
}