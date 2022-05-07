using System;

namespace InterfaceOrnek
{
    public class cotolla : IOtomobil
    {
        public Marka MarkasıNe()
        {
           return Marka.Toyota;
        }

        public Renk StandartRenk()
        {
            return Renk.Beyaz;
        }

        public int TekerlekSayısı()
        {
            return 4;
        }
    }
}