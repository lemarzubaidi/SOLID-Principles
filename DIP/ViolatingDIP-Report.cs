using System;

public class PdfReportGenerate
{
    public void Generate()
    {
        Console.WriteLine("Generating PDF report...");
       
    }
}

public class ReportGenerator
{
      private PdfReportGenerate _pdfReportGenerate;

    public ReportGenerator()
    {
        _pdfReportGenerate = new PdfReportGenerate();
    }
    public void GenerateReport() { 
    _pdfReportGenerate.Generate();
    }
} 
public class Program
{
    public static void Main(string[] args)
    {
        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.GenerateReport();


    }
}