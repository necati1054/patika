using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaÇoğalma();

            Console.WriteLine("****** ****** ****** ******");
            
            Kuşlar martı = new Kuşlar();
            martı.Uçmak();
        }
    }
}
