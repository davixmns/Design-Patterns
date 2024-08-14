namespace Design_Patterns.Facade;

public class FacadeProgram
{
    
    /*
       O padrão Facade é um padrão de design estrutural que fornece uma interface simplificada
       para um conjunto de interfaces em um subsistema. Ele define uma interface de nível 
       mais alto que torna o subsistema mais fácil de usar.
       
       Componentes principais:
       Facade: A classe que fornece uma interface simplificada para o subsistema.
       Subsystem Classes: As classes que compõem o subsistema complexo. 
       Elas realizam o trabalho real e têm interfaces complexas.
     */
    public static void Run()
    {
        MyFacade facade = new();
        
        Client client = new("John Doe");

        bool loanApproved = facade.GrantLoan(client, 20000);

        Console.WriteLine(loanApproved ? "Loan approved!" : "Loan denied!");

        Console.ReadKey();
    }
}