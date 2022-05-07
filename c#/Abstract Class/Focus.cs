using System;

namespace InterfaceOrnek
{
    public class Focus : IOtomobil
    {
        public Marka MarkasıNe()
        {
            return Marka.Ford;
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