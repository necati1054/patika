using System;

namespace InterfaceOrnek
{
    public class Civic : IOtomobil
    {
        public Marka MarkasıNe()
        {
            return Marka.Honda;
        }

        public Renk StandartRenk()
        {
            return Renk.Gri;
        }

        public int TekerlekSayısı()
        {
            return 4;
        }
    }
}