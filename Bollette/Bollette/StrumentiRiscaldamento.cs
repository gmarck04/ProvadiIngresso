using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    /**
     * \class StrumentiRiscaldamento
     * \brief La classe StrumentiRiscaldamento quando viene utilizzata chiede attraverso il metodo costruttore le variabili Costo, CodiceRendimento e Potenza.
     */
    class StrumentiRiscaldamento
    {
        /// \brief Rendimento dello strumento di riscaldamento
        protected double Rendimento;
        /// \brief Costo dello strumento di riscaldamento
        protected double Costo;
        /// \brief Potenza dello strumento di riscaldamento
        protected double Potenza;

        /**
        * \brief Metodo costruttore, riceve in input le variabili di tipo double Costo e Potenza e la variabile di tipo int CodiceRendimento.
        * \details La variabile Rendimento prende il valore ritornato della funzione SetRendimento(int codice).
        */
        public StrumentiRiscaldamento(double Costo, int CodiceRendimento, double Potenza)
        {
            this.Costo = Costo;
            this.Rendimento = SetRendimento(CodiceRendimento);
            this.Potenza = Potenza;
        }

        /**
         * \fn      public double GetPotenzaEffettiva()
         * \brief   Ritorna la motipicazione eseguita fra Potenza e Rendimento.
         * \return  Potenza * Rendimento
         */
        public double GetPotenzaEffettiva()
        {
            return Potenza * Rendimento;
        }

        /**
         * \fn      public double GetCosto(double CostoBolletta)
         * \brief   Ritorna la somma eseguita fra Costo e CostoBolletta.
         * \return  Costo + CostoBolletta
         */
        public double GetCosto(double CostoBolletta)
        {
            return Costo + CostoBolletta;
        }


        /**
         * \fn      protected double SetRendimento(int codice)
         * \brief   Restituisce il rendimento dello strumento di riscaldamento.
         * \details Prende il valore di codice e esegue una serie di if, se il valore è uguale a 1 allora restituisce 3.6, se il valore è uguale a 2 allora restituisce 2.8, 
         * se il valore è uguale a 3 allora restituisce 0.9 e se il valore è uguale a 4 o 5 allora restituisce 1.
         * \return  3.6
         * \return  2.8
         * \return  0.9
         * \return  1
         * \return  1
         * \return  -1
         */
        protected double SetRendimento(int codice)
        {
            if (codice == 1)
                return 3.6;
            else if (codice == 2)
                return 2.8;
            else if (codice == 3)
                return 0.9;
            else if (codice == 4)
                return 1;
            else if (codice == 5)
                return 1;
            return -1;
        }
    }
}
