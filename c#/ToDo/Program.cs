using System;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.DefaultCard();
            operation.DefaultPerson();
            operation.start();
            bool kontrol = true;
            while(kontrol)
            {
                Console.WriteLine("Lütfen 1 - 5 Arasında Bir İşlem Seçiniz");
                int No = int.Parse(Console.ReadLine());
                if(No< 1 || No >5)
                {
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız Lütfen 1-5 Arasında Bir Seçim Yapınız");
                    continue;
                }
                switch (No)
                {
                    case 1: operation.listele(); break;
                    case 2: operation.add(); break;
                    case 3: operation.Delete(); break;
                    case 4: operation.transfer(); break;
                    case 5: kontrol = false; break;
                }
            }
        }
    }
}
