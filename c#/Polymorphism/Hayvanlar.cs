using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar Temas a tepki verir");
        }
    }
    
    public class Sürüngenler:Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SürünerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }

    public class Kuşlar:Hayvanlar
    {
        public Kuşlar()
        {
            base.Adaptasyon();
            base.beslenme();
            base.Boşaltım();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Uçmak()
        {
            Console.WriteLine("Kuşlar Uçar");
        }
    }
}