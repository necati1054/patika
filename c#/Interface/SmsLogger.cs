using System;

namespace Interface
{
    public class SmsLogger : ILogger //İmplamente etmemiz gerek.
    {
        public void WriteLog() 
        {
            // throw new NotImplementedException(); //implamentin gövdesini boş bırakılabilir.
            Console.WriteLine("Sms Olarak Log Yazar");
        }
    }
}