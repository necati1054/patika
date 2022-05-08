using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.DefaultListe();
            operation.start();
            bool kontrol = true;
            while(kontrol)
            {
                Console.WriteLine("Lütfen 1 - 6 Arasında Bir İşlem Seçiniz");
                int No = int.Parse(Console.ReadLine());
                if(No< 1 || No >6)
                {
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız Lütfen 1-6 Arasında Bir Seçim Yapınız");
                    continue;
                }
                switch (No)
                {
                    case 1: operation.Add(); break;
                    case 2: operation.Delete(); break;
                    case 3: operation.Update(); break;
                    case 4: operation.List(); break;
                    case 5: operation.search(); break;
                    case 6: kontrol = false; break;
                }
            }
        }
    }
}
