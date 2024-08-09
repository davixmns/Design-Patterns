namespace Design_Patterns.Decorator;

//Concrete Component
public class FinancialReport : IReport
{
    private string _content;
    
    public FinancialReport(string content)
    {
        _content = content;
    }
    
    public string Generate()
    {
        Console.WriteLine("Gerando relatorio financeiro");
        return $"Conteudo do relatorio: {_content}";
    }
}