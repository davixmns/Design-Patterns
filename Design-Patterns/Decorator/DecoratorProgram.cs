namespace Design_Patterns.Decorator;

public class DecoratorProgram
{
    public static void Run()
    {
        //Component
        IReport report;
        
        //Concrete Component
        report= new FinancialReport("20% de crescimento");
        
        //Concrete Decorator
        report = new PdfReportDecorator(report);
        
        //Concrete Decorator
        report = new SignedReportDecorator(report, "Davi Ximenes");
        
        Console.WriteLine(report.Generate());
    }
}