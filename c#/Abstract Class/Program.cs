using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** ****** Interface ****** ******");
            Focus focus = new Focus();
            Console.WriteLine(focus.MarkasıNe().ToString());
            Console.WriteLine(focus.TekerlekSayısı());
            Console.WriteLine(focus.StandartRenk().ToString());

            Console.WriteLine("****** ****** ****** ******");

            Civic Civic = new Civic();
            Console.WriteLine(Civic.MarkasıNe().ToString());
            Console.WriteLine(Civic.TekerlekSayısı());
            Console.WriteLine(Civic.StandartRenk().ToString());

            Console.WriteLine("****** ****** Abstract  ****** ******");

            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.MarkasıNe().ToString());
            Console.WriteLine(focus1.TekerlekSayısı());
            Console.WriteLine(focus1.StandartRenk().ToString());

            Console.WriteLine("****** ****** ****** ******");

            NewCivic Civic1 = new NewCivic();
            Console.WriteLine(Civic1.MarkasıNe().ToString());
            Console.WriteLine(Civic1.TekerlekSayısı());
            Console.WriteLine(Civic1.StandartRenk().ToString());
        }
    }
}       
