using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    /**
    * \class Gas
    * \brief La classe Gas è una classe figlia della classe Energia quando viene utilizzata chiede attraverso il metodo costruttore le variabili MateriaUtilizzata e CostoMateriaUtilizzata.
    */
    class Gas : Energia
    {
        /// \brief Quota Vendita al Dettaglio fissata a 70.
        int QVD = 70;

        /**
        * \brief Metodo costruttore, riceve in input le variabili di tipo double MateriaUtilizzata e CostoMateriaUtilizzata.
        */
        public Gas(double MateriaUtilizzata, double CostoMateriaUtilizzata) : base(MateriaUtilizzata, CostoMateriaUtilizzata)
        {

        }

        /**
         * \fn      protected override double TotaleNetto()
         * \brief   Restituisce il totale della bolletta senza iva.
         * \details Prende il valore restituito dal metodo CostoMateriaPrima(), lo somma alle variabili CostoTrasporto, OneriSistema e QVD e lo ritorna.
         * \return  CostoMateriaPrima() + CostoTrasporto + OneriSistema
         */
        protected override double TotaleNetto()
        {
            return CostoMateriaPrima() + CostoTrasporto + OneriSistema + QVD;
        }

        /**
       * \fn      public double GetPotenzaGasALuce()
       * \brief   Ritorna la moltiplicazione eseguita fra MateriaUtilizzata e 10.7.
       * \return  MateriaUtilizzata * 10.7
       */
        public double GetPotenzaGasALuce()
        {
            return MateriaUtilizzata * 10.7;
        }
    }
}
