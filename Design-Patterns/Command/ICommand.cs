namespace Design_Patterns.Command;

//Command Interface
public interface ICommand
{
    void Execute();
    void Undo();
}