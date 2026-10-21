using System;
public interface IPayment
{
    void PayWithCreditCard();
    void PayWithPayPal();
     
    void PayWithBitcoin();
}
public class CreditCardPayment : IPayment
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment made with Credit Card.");
    }
    public void PayWithPayPal()
    {
        throw new NotImplementedException();
    }
    public void PayWithBitcoin()
    {
        throw new NotImplementedException();
    }
}
public class  PayPalPayment:IPayment
{
     public void PayWithCreditCard()
    {
        throw new NotImplementedException();
    }
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment made with Pay Pal.");
    }
    public void PayWithBitcoin()
    {
        throw new NotImplementedException();
    }
}
public class BitcoinPayment : IPayment
{
    public void PayWithCreditCard()
    {
        throw new NotImplementedException();
    }
    public void PayWithPayPal()
    {
        throw new NotImplementedException();
    }
    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment made with Bitcoin.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        IPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
        IPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();
        IPayment bitcoinPayment = new BitcoinPayment();
        bitcoinPayment.PayWithBitcoin();
    }
}