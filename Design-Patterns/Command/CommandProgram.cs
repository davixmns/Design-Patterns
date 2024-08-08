namespace Design_Patterns.GoF.Command;

public class CommandProgram
{
    
    /*
       O padrão Command é um padrão de design comportamental que transforma uma solicitação em um
       objeto independente que contém todas as informações sobre a solicitação. Isso permite que 
       você parametrize métodos com diferentes solicitações, enfileire ou registre solicitações 
       e suporte operações que podem ser desfeitas. 
       
       Componentes principais:
       Command: Interface ou classe abstrata que declara o método Execute.
       ConcreteCommand: Implementa a interface Command e define a ligação entre um Receiver e uma ação.
       Receiver: A classe que realiza a ação real quando o comando é executado.
       Invoker: Classe que solicita a execução dos comandos.
       Client: Cria e configura os objetos ConcreteCommand e Invoker.
     */
    
    public static void Run()
    {
        //Receiver
        var chef = new Chef();
        
        //Concrete Command 1
        var order1 = new Order(chef, "appetizer");
        
        //Invoker
        var waiter = new Waiter(order1);
        waiter.TakeOrder();
        
        //Concrete Command 2
        var order2 = new Order(chef, "main course");
         
        waiter.PlaceOrder(order2);
        
        waiter.TakeOrder();
    }
}