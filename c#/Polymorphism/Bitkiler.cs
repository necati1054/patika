using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez yapar"); 
        }

        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneş e tepki verir");
        }
    }
    
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.beslenme();
            base.Boşaltım();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaÇoğalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SporlaaÇoğalma()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır");
        }
    }
}