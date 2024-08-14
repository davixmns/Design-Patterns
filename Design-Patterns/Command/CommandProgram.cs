using Design_Patterns.Command;

namespace Design_Patterns.Command;

public class CommandProgram
{
    public static void Run()
    {
        BankAccount account = new BankAccount("123456", 1000);
        TransactionManager manager = new TransactionManager();

        // Execute transactions
        manager.ExecuteTransaction(new DepositCommand(account, 500));
        manager.ExecuteTransaction(new WithdrawCommand(account, 200));

        // Undo last transaction
        manager.UndoTransaction();

        // Redo undone transaction
        manager.RedoTransaction();
        
        Console.WriteLine(account);
    }
}