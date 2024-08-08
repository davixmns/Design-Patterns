namespace Design_Patterns.Decorator;

public class SignedReportDecorator : ReportDecorator
{
    private string _signature;
    
    public SignedReportDecorator(IReport report, string signature) : base(report)
    {
        _signature = signature;
    }
    
    public override string Generate()
    {
        var content = base.Generate();
        Console.WriteLine("Assinando relatorio");
        return $"{content} assinado por {_signature}";
    }
}