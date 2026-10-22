using System;
//DIP:High-Level should not depend on low-level modules. Both should depend on abstractions.
//This Code is Compatible SRP,OCP,DIP+ DI design pattern
public interface  IReportGenerator
{
    void Generator();

}
public class PdfReportGenerate:IReportGenerator
{
    public void Generator()
    {
        Console.WriteLine("Generating PDF report...");

    }
}
public class ExcelReportGenerate : IReportGenerator
{
    public void Generator()
    {
        Console.WriteLine("Generating Excel report...");

    }
}
public class WordReportGenerate : IReportGenerator
{
    public void Generator()
    {
        Console.WriteLine("Generating Word report...");

    }
}
public class CrystalReportGenerate : IReportGenerator
{
    public void Generator()
    {
        Console.WriteLine("Generating Crystal report...");

    }
}
public class ReportGenerator
{
    private IReportGenerator _ReportGenerate;
    //Dependency (Injection) design pattern  example the object of the low-level module is injected into the high-level module through the constructor.
    public ReportGenerator(IReportGenerator reportGenerator)
    {
        _ReportGenerate = reportGenerator;
    }
    public void GenerateReport()
    {
        _ReportGenerate.Generator();    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //Dependency (Injection)  design pattern example the obj ect of the low-level module is injected into the high-level module through the constructor.
        ReportGenerator reportGenerator = new ReportGenerator(new PdfReportGenerate());
        reportGenerator.GenerateReport();
        reportGenerator = new ReportGenerator(new ExcelReportGenerate());
        reportGenerator.GenerateReport();
        reportGenerator = new ReportGenerator(new WordReportGenerate());
        reportGenerator.GenerateReport();
        reportGenerator = new ReportGenerator(new CrystalReportGenerate());
        reportGenerator.GenerateReport();



    }
}
