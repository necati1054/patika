using System;

namespace Inheritance
{
    public class Canlilar //sealed kalıtım vermesini kapatıyor
    {
        protected void beslenme()
        {
            Console.WriteLine("Canlılar Beslenir");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar");
        }
        protected void Boşaltım()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar Uyaranlara Tepki Verir");
        }
    }
}
