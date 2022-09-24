using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    /**
    * \class Luce
    * \brief La classe Luce è una classe figlia della classe Energia quando viene utilizzata chiede attraverso il metodo costruttore le variabili MateriaUtilizzata e CostoMateriaUtilizzata.
    */
    class Luce : Energia
    {
        /**
        * \brief Metodo costruttore, riceve in input le variabili di tipo double MateriaUtilizzata e CostoMateriaUtilizzata.
        */
        public Luce(double MateriaUtilizzata, double CostoMateriaUtilizzata) : base(MateriaUtilizzata, CostoMateriaUtilizzata)
        {
        }

        /**
         * \fn      public double GetPotenzaLuceAGas()
         * \brief   Ritorna la divisione eseguita fra MateriaUtilizzata e 10.7.
         * \return  MateriaUtilizzata / 10.7
         */
        public double GetPotenzaLuceAGas()
        {
            return MateriaUtilizzata / 10.7;
        }
    }
}
