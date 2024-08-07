
namespace Design_Patterns.GoF.Observer;

public class ObserverProgram
{
    /*
       O padrão Observer é um padrão comportamental que define uma dependência
       de um-para-muitos entre objetos de modo que quando um objeto muda de estado,
       todos os seus dependentes são notificados e atualizados automaticamente.
        
       Um objeto SUBJECT publica ou atualiza uma informação e existem objetos OBSERVERS
       que se registram-se no SUBJECT para receber atualizações quando 
       os dados do SUBJECT são alterados. Os OBSERVERs também podem cancelar
        o seu registro e dessa forma não receber mais nenhuma atualização do SUBJECT. 
     */
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