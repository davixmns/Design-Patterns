namespace Design_Patterns.Command;

//Invoker
public class TransactionManager
{
    private List<ICommand> _commands = [];
    private int _currentCommandIndex = 0;
    
    public void ExecuteTransaction(ICommand command)
    {
        command.Execute();
        _commands.Add(command);
        _currentCommandIndex++;
    }
    
    public void UndoTransaction()
    {
        if (_currentCommandIndex > 0)
        {
            _commands[_currentCommandIndex - 1].Undo();
            _currentCommandIndex--;
        }
    }

    public void RedoTransaction()
    {
        if (_currentCommandIndex < _commands.Count)
        {
            _commands[_currentCommandIndex].Execute();
            _currentCommandIndex++;
        }
    }
    
}