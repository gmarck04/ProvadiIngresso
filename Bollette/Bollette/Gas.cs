using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class Gas : Energia
    {
        int QVD = 70;
        public Gas(double MateriaUtilizzata, double CostoMateriaUtilizzata) : base(MateriaUtilizzata, CostoMateriaUtilizzata)
        {

        }
        protected override double TotaleNetto()
        {
            return CostoMateriaPrima() + CostoTrasporto + OneriSistema + QVD;
        }
        public double GetPotenzaGasALuce()
        {
            return MateriaUtilizzata * 10.7;
        }
    }
}
