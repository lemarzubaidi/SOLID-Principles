using System;
using System.Drawing;

public interface IPrinter
{
    void Print(string message);
    void Scan();
    void Fax();
}
public class  BasicPrinter :IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing: {message}");
    }
    public void Scan()
    {
        throw new NotImplementedException();
    }
    public void Fax()
    {
        throw new NotImplementedException();
    }   
}
public class AdvancedPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing: {message}");
    }
    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
    public void Fax()
    {
        Console.WriteLine("Sending fax...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Hello, World!");
        // basicPrinter.Scan(); // This will throw NotImplementedException
        // basicPrinter.Fax();  // This will throw NotImplementedException
        IPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print("Hello, World!");
        advancedPrinter.Scan();
        advancedPrinter.Fax();
    }
}   