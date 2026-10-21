using System;
using System.Drawing;

public interface IPrinter
{
    void Print(string message);
   
}
public interface Isacn
{
   void Scan();
  
}
public interface IFax
{
   void Fax();

}
public class BasicPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing: {message}");
    }
    
}
public class AdvancedPrinter : IPrinter, Isacn , IFax
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
       BasicPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Hello, World!");
       
       AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print("Hello, World!");
       advancedPrinter.Scan();
        advancedPrinter.Fax();
    }
}
