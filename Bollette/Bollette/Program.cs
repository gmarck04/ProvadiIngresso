using System;

namespace Bollette
{
    class Program
    {
        static void Main(string[] args)
        {
            //float CostoMateriaPrima = 0, CostoGestione = 0, Tasse = 0;

            //Energia energia = new Energia(CostoMateriaPrima, CostoGestione, Tasse);
            Gas energia = new Gas(100, 300, 121, 10);

            Console.WriteLine(energia.TotaleLordo());
        }
    }
}
