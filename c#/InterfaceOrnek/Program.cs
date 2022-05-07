using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.MarkasıNe().ToString());
            Console.WriteLine(focus.TekerlekSayısı());
            Console.WriteLine(focus.StandartRenk().ToString());

            Civic Civic = new Civic();
            Console.WriteLine(Civic.MarkasıNe().ToString());
            Console.WriteLine(Civic.TekerlekSayısı());
            Console.WriteLine(Civic.StandartRenk().ToString());
        }
    }
}       
