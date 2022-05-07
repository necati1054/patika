using System;

namespace InterfaceOrnek
{
    public abstract class Otomobil
    {
        public int TekerlekSayısı()
        {
            return 4;
        }

        public virtual Renk StandartRenk()
        {
            return Renk.Beyaz;
        }

        public abstract Marka MarkasıNe();
    }
}