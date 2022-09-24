using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class Energia
    {
        protected double CostoTrasporto = 96, OneriSistema = 47, MateriaUtilizzata, CostoMateriaUtilizzata;
        public Energia(double MateriaUtilizzata, double CostoMateriaUtilizzata)
        {
            this.MateriaUtilizzata = MateriaUtilizzata;
            this.CostoMateriaUtilizzata = CostoMateriaUtilizzata;
        }

        protected virtual double TotaleNetto()
        {
            return CostoMateriaPrima() + CostoTrasporto + OneriSistema;
        }
        
        protected double CostoMateriaPrima()
        {
            return MateriaUtilizzata * CostoMateriaUtilizzata;
        }

        public double TotaleLordo()
        {
            return Math.Round(((TotaleNetto() / 100) * 122), 2);
        }

        public virtual double GetPotenzaNormale()
        {
            return MateriaUtilizzata;
        }
    }
}
