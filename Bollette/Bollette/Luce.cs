using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class Luce : Energia
    {
        public Luce(double MateriaUtilizzata, double CostoMateriaUtilizzata) : base(MateriaUtilizzata, CostoMateriaUtilizzata)
        {
        }
        public double GetPotenzaLuceAGas()
        {
            return MateriaUtilizzata / 10.7;
        }
    }
}
