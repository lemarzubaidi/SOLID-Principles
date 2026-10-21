using System;


namespace ConsoleApp42
{

    public class NotificationService
    {
        private Inotification _notification;
        public NotificationService(Inotification notification)
        {
            _notification = notification;
        }
        public void SendNotification(string to, string message)
        {
           _notification.Send(to, message);
        }
    }
   public interface Inotification 
    {
         void Send(string to, string message);
    }
    public class EmailService : Inotification
    {
        public  void Send(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to} with message: {message}");
        }
    }
    public class SMSService : Inotification
    {
        public  void Send(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to} with message: {message}");
        }
    }
    public class FaxService:Inotification
    {
        public  void Send(string to, string message)
        {
            Console.WriteLine($"Sending Fax to {to} with message: {message}");
        }
    }
    public class whatsappService : Inotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending WhatsApp to {to} with message: {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService(new EmailService());
            notificationService.SendNotification("John@example.com","Welcom to our Service");

            notificationService = new NotificationService(new SMSService());
            notificationService.SendNotification("+123456789", "Your OTP code is 1234");

             notificationService = new NotificationService(new FaxService());
            notificationService.SendNotification("1-23-456-789", "Fax meessage:important document");

             notificationService = new NotificationService(new whatsappService() );
         notificationService.SendNotification("+555586932", "Welcom to our Service");

        }
    }
}
