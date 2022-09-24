using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    /**
     * \class Energia
     * \brief La classe Energia quando viene utilizzata chiede attraverso il metodo costruttore le variabili MateriaUtilizzata e CostoMateriaUtilizzata.
     */
    class Energia
    {
        /// \brief Costo del trasposrto della materia prima
        protected double CostoTrasporto = 96;
        /// \brief Oneri del sistema dettati dall'ARERA
        protected double OneriSistema = 47;
        /// \brief Quantitativo utilizzato di una determinata materia prima (luce o gas metano) 
        protected double MateriaUtilizzata;
        /// \brief Costo della materia prima (luce o gas metano) 
        protected double CostoMateriaUtilizzata;

        /**
        * \brief Metodo costruttore, riceve in input le variabili di tipo double MateriaUtilizzata e CostoMateriaUtilizzata.
        */
        public Energia(double MateriaUtilizzata, double CostoMateriaUtilizzata)
        {
            this.MateriaUtilizzata = MateriaUtilizzata;
            this.CostoMateriaUtilizzata = CostoMateriaUtilizzata;
        }

        /**
         * \fn      protected virtual double TotaleNetto()
         * \brief   Restituisce il totale della bolletta senza iva.
         * \details Prende il valore restituito dal metodo CostoMateriaPrima(), lo somma alle variabili CostoTrasporto e OneriSistema e lo ritorna.
         * \return  CostoMateriaPrima() + CostoTrasporto + OneriSistema
         */
        protected virtual double TotaleNetto()
        {
            return CostoMateriaPrima() + CostoTrasporto + OneriSistema;
        }

        /**
         * \fn      protected double CostoMateriaPrima()
         * \brief   Ritorna la motipicazione eseguita fra MateriaUtilizzata e CostoMateriaUtilizzata.
         * \return  MateriaUtilizzata * CostoMateriaUtilizzata
         */
        protected double CostoMateriaPrima()
        {
            return MateriaUtilizzata * CostoMateriaUtilizzata;
        }

        /**
         * \fn      public double TotaleLordo()
         * \brief   Restituisce il totale della bolletta con iva.
         * \details Prende il valore restituito dal metodo TotaleNetto(), lo divide per 100, poi lo moliplica per 122, poi utilizzando la funzione Math.Round() arrotonda il valore alla seconda cifra decimale e lo ritorna.
         * \return  Math.Round(((TotaleNetto() / 100) * 122), 2)
         */
        public double TotaleLordo()
        {
            return Math.Round(((TotaleNetto() / 100) * 122), 2);
        }

        /**
         * \fn      public virtual double GetPotenzaNormale()
         * \brief   Ritorna la variabile di tipo double MateriaUtilizzata.
         * \return  MateriaUtilizzata: variabile inserita dall'utente nel metodo costruttore
         */
        public virtual double GetPotenzaNormale()
        {
            return MateriaUtilizzata;
        }
    }
}
