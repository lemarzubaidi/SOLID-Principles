using System;
public interface IPayWthCreditCard
{
    void PayWithCreditCard();

}
public interface IPayWithPayPal
{
    void PayWithPayPal();
}
public interface IPayWithBitcoin
{
    void PayWithBitcoin();
}
public class CreditCardPayment : IPayWthCreditCard
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment made with Credit Card.");
    }
   
}
public class PayPalPayment : IPayWithPayPal
{
   
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment made with Pay Pal.");
    }
   
}
public class BitcoinPayment : IPayWithBitcoin
{
 
    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment made with Bitcoin.");
    }
}
public class AllPayments:IPayWithBitcoin, IPayWithPayPal, IPayWthCreditCard
{
    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment made with Bitcoin.");
    }
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment made with Credit Card.");
    }
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment made with Pay Pal.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
       CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
       PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();
       BitcoinPayment bitcoinPayment = new BitcoinPayment();
        bitcoinPayment.PayWithBitcoin();
        AllPayments allPayments = new AllPayments();
        allPayments.PayWithCreditCard();
        allPayments.PayWithPayPal();
        allPayments.PayWithBitcoin();
    }
}