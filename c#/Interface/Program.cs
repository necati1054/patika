using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger FileLogger = new FileLogger();
            FileLogger.WriteLog();

            DataBaseLogger DatabaseLogger = new DataBaseLogger();
            DatabaseLogger.WriteLog();

            SmsLogger SmsLogger = new SmsLogger();
            SmsLogger.WriteLog();

            Console.WriteLine("****** ****** ****** ******");

            LogManager logManager = new LogManager(new FileLogger()); //Bir Nesnesini Oluşturmadan da DosyayaLog yazdıra biliriz.
            logManager.WriteLog();
        }
    }
}
