using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette
{
    class StrumentiRiscaldamento
    {
        protected double Rendimento, Costo, Potenza;

        public StrumentiRiscaldamento(double Costo, int CodiceRendimento, double Potenza)
        {
            this.Costo = Costo;
            this.Rendimento = SetRendimento(CodiceRendimento);
            this.Potenza = Potenza;
        }

        public double GetPotenzaEffettiva()
        {
            return Potenza * Rendimento;
        }

        public double GetCosto(double CostoBolletta)
        {
            return Costo + CostoBolletta;
        }

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
