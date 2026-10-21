using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{

    public class PaymentService
    {
        private IPaymentService _paymentService;
        public PaymentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
       public void Payment(decimal amount)
        {
            _paymentService.ProcessPayment(amount);
        }
    }
    public interface IPaymentService
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPal : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} via PayPal.");
        }
    }
    public class CrediteCard : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} via CrediteCard.");
        }
    }
    public class BankTransfer : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Bank Transfer.");
        }
    }
    public class Bitcoin : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Bitcoin.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService(new PayPal());
            paymentService.Payment(100.00m);
            paymentService = new PaymentService(new CrediteCard());
            paymentService.Payment(200.00m);
            paymentService = new PaymentService(new BankTransfer());
            paymentService.Payment(300.00m);
            paymentService = new PaymentService(new Bitcoin());
            paymentService.Payment(400.00m);
        }
    }
}
