using System;


namespace ConsoleApp43
{
    public class LoggingService
    {
        private ILoggingService _loggingService;
        public LoggingService(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }
        public void Log(string message)
        {
          _loggingService.Log(message);
        }
    }
    public interface ILoggingService
    {
        void Log(string message);
    }
    public class ToFileService : ILoggingService
    {
        public  void Log(string message)
        {
            Console.WriteLine("File: "+message);
        }


    }

    public class ToEvent: ILoggingService
    {
        public  void Log(string message)
        {
            Console.WriteLine("Event"+message);
        }
    }
    public class ToDataBase : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine("DataBase"+message);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the LoggingService
            LoggingService LoggingService = new LoggingService(new ToFileService());

            // Log to File
            LoggingService.Log("Error   Occured line xxx.");

            LoggingService = new LoggingService(new ToDataBase());
         
            LoggingService.Log("Error  Occured line xxx.");

         
           LoggingService = new LoggingService(new ToEvent());
            LoggingService.Log("Error   Occured line xxx.");
        }
    }
}