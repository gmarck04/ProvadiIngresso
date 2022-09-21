using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class Energia
    {
        protected float CostoTrasporto, OneriSistema, MateriaUtilizzata;
        public Energia(float MateriaUtilizzata)
        {
            this.MateriaUtilizzata = MateriaUtilizzata;
        }

        protected virtual float TotaleNetto(float Costo)
        {
            return CostoMateriaPrima(Costo) + CostoTrasporto + OneriSistema;
        }
        
        protected float CostoMateriaPrima(float Costo)
        {
            return MateriaUtilizzata * Costo;
        }

        public float TotaleLordo(float Costo)
        {
            return (float)Math.Round(((TotaleNetto(Costo) / 100) * 122), 2);
        }

        protected virtual double GetPotenza()
        {
            return MateriaUtilizzata;
        }
    }
}
