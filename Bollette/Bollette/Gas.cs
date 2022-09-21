using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class Gas : Energia
    {
        float QVD;
        public Gas(float MateriaUtilizzata) : base(MateriaUtilizzata)
        {

        }
        protected override float TotaleNetto(float Costo)
        {
            return CostoMateriaPrima(Costo) + CostoTrasporto + OneriSistema + QVD;
        }
        protected override double GetPotenza()
        {
            return MateriaUtilizzata * 10.7;
        }
    }
}
