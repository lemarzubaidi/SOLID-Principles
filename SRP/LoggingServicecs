using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public class  LoggingService
    {
        public enum enLoggingType { ToFile,ToEventLog,ToDataBase};
        public void Log(string message, enLoggingType loggingType)
        {
            switch (loggingType)
            {
                case enLoggingType.ToFile:
                   ToFileService.LogToFile(message);
                    break;
                case enLoggingType.ToEventLog:
                   ToEvent.LogToEvent(message);
                    break;
                case enLoggingType.ToDataBase:
                    ToDataBase.LogToDataBase(message);
                    break;
          
            }
        }
    }
    public class ToFileService 
    {
       public static void LogToFile(string message)
        {
            Console.WriteLine(message);
        }
   

    }

    public class ToEvent 
    {
        public static void LogToEvent(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ToDataBase
    {
        public static void LogToDataBase(string message)
        {
            Console.WriteLine(message);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the LoggingService
            LoggingService LoggingService = new LoggingService();

            // Log to File
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

            // Log to Event Log
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

            // Log to Database
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDataBase);
        }
    }
}
