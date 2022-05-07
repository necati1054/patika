using System;

namespace InterfaceOrnek
{
    public class NewCivic : Otomobil
    {
        public override Marka MarkasıNe()
        {
            return Marka.Honda;
        }

        public override Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}