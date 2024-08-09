namespace Design_Patterns.Decorator;

//Concrete Decorator
public class PdfReportDecorator : ReportDecorator
{
    public PdfReportDecorator(IReport report) : base(report)
    {
        
    }
    
    public override string Generate()
    {
        var content = base.Generate();
        Console.WriteLine("Formatando relatorio em PDF");
        return $"Relatorio Formatado em PDF: {content}";
    }
}