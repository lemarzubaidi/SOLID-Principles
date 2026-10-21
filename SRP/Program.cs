using System;


namespace ConsoleApp42
{

    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, Fax };
        public void SendNotification(string to, string message,enNotificationType notificationType)
        {
            switch (notificationType)
            {
                case enNotificationType.Email:
                    EmailService.SendEmail(to, message);
                    break;
                case enNotificationType.SMS:
                    SMSService.SendSMS(to, message);
                    break;
                case enNotificationType.Fax:
                    FaxService.SendFax(to, message);
                    break;
               
            }
        }
    }
    public class EmailService 
    {
        public static void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to} with message: {message}");
        }
    }
    public class SMSService
    {
        public static void SendSMS(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to} with message: {message}");
        }
    }
    public class FaxService
    {
        public static void SendFax(string to, string message)
        {
            Console.WriteLine($"Sending Fax to {to} with message: {message}");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
