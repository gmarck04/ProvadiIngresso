/** 
 * \file Program.cs
 * \author @gmarck04
 * \date 24/09/2022
 * \brief Il programma è un comparatore di strumenti di riscaldamento
 * Consegna:
    Escludendo il calcolo delle accise, in base ai consumi annui (variabili) di una determinata utenza, trovare gli attuali prezzi di mercato con lo scopo di paragonare 
    quando possa essere conveniente installare nuove pompe di calore, quando possa essere farlo mantenendo le attuali pompe di calore, quando sia conveniente utilizzare 
    il vecchio sistema di riscaldamento e quando, nel caso possa esserlo, sia conveniente utilizzare stufe elettriche.

    Dovranno essere consegnate:
        - Analisi dei requisiti;
        - Analisi delle funzionalità del prodotto software e dell'interazione con l'utente;
        - Analisi tecnica con indicazione delle classi e dei metodi;
        - Realizzazione, con codice accuratamente commentato, di tutto il codice possibile o delle parti salienti (in base al tempo)
        - Rendicontazione dei tempi (ore di lavoro e studio per ogni attività)
        - Autovalutazione e analisi dei punti critici */

using System;

namespace Bollette
{
    /**
     * \class Program
     * \brief La classe Programm è la classe principale del programma, che ha il compito di interfacciarsi con l'utente
     */
    class Program
    {

        /**
         * \fn      static void Main(string[] args)
         * \brief   Eseguo il codice richiamando una serie di funzioni
         * \details La funzione Main chiama la funzione menù() e la funzione Console.ReadKey()
         */
        static void Main(string[] args)
        {
            menù();
            Console.ReadKey();
        }

        /**
         * \fn      public static double MateriaUtilizzata()
         * \param   scelta: variabile inserita dall'utente
         * \param   controllo: valore per il controllo, successivo al tentativo con una funzione TryParse
         * \brief   Viene visualizzato un menù per scelgliere le azioni da compiere
         * \details Viene visualizzata la stringa "Inserisci i consumi annuali della famiglia.", do alla variabile di tipo bool controllo il valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta.
         * Inizia un ciclo while, se il controllo è falso o se la variabile scelta è minore di 0, allora inizia il ciclo e viene mostrata
         * la stringa "Errato. Inserisci i consumi annuali della famiglia.", poi do alla variabile di tipo bool controllo il valore pari al valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta, se il ciclo finisce allora viene ritornata 
         * la variabile scelta.
         * \return  scelta: valore inserito dall'utente.
         */
        public static double MateriaUtilizzata()
        {
            double scelta;
            Console.WriteLine("Inserisci i consumi annuali della famiglia.");
            bool controllo = double.TryParse(Console.ReadLine(), out scelta); //Inizializzo la variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            while (!controllo || (scelta < 0)) //Ciclo while, che si avvia se controllo è falso o se la variabile numero_squadre è minore di 0 o maggiore di 14.
            {
                Console.WriteLine("Errato. Inserisci i consumi annuali della famiglia."); //Scrive su console la stringa.
                controllo = double.TryParse(Console.ReadLine(), out scelta); //Do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            }
            return scelta;
        }

        /**
         * \fn      public static double RichiediCostoStrumento()
         * \param   scelta: variabile inserita dall'utente
         * \param   controllo: valore per il controllo, successivo al tentativo con una funzione TryParse
         * \brief   Viene visualizzato un menù per scelgliere le azioni da compiere
         * \details Viene visualizzata la stringa "Inserisci il costo dello strumento.", do alla variabile di tipo bool controllo il valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta.
         * Inizia un ciclo while, se il controllo è falso o se la variabile scelta è minore di 0, allora inizia il ciclo e viene mostrata
         * la stringa "Errato. Inserisci il costo dello strumento.", poi do alla variabile di tipo bool controllo il valore pari al valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta, se il ciclo finisce allora viene ritornata 
         * la variabile scelta.
         * \return  scelta: valore inserito dall'utente.
         */
        public static double RichiediCostoStrumento()
        {
            double scelta;
            Console.WriteLine("Inserisci il costo dello strumento.");
            bool controllo = double.TryParse(Console.ReadLine(), out scelta);
                Console.WriteLine("Errato. Inserisci il costo dello strumento."); 
                controllo = double.TryParse(Console.ReadLine(), out scelta); 
            return scelta;
        }

        /**
         * \fn      public static double RichiediCostoMateria()
         * \param   scelta: variabile inserita dall'utente
         * \param   controllo: valore per il controllo, successivo al tentativo con una funzione TryParse
         * \brief   Viene visualizzato un menù per scelgliere le azioni da compiere
         * \details Viene visualizzata la stringa "Inserisci il costo della materia prima.", do alla variabile di tipo bool controllo il valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta.
         * Inizia un ciclo while, se il controllo è falso o se la variabile scelta è minore di 0, allora inizia il ciclo e viene mostrata
         * la stringa "Errato. Inserisci il costo della materia prima.", poi do alla variabile di tipo bool controllo il valore pari al valore ritornato dalla funzione TryParse,
         * che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in double e lo inserisce in scelta, se il ciclo finisce allora viene ritornata 
         * la variabile scelta.
         * \return  scelta: valore inserito dall'utente.
         */
        public static double RichiediCostoMateria()
        {
            double scelta;
            Console.WriteLine("Inserisci il costo della materia prima.");
            bool controllo = double.TryParse(Console.ReadLine(), out scelta);
            {
                Console.WriteLine("Errato. Inserisci il costo della materia prima.");

                controllo = double.TryParse(Console.ReadLine(), out scelta);

            }
            return scelta;
        }

        /**
         * \fn      public static int menu_scelta()
         * \param   scelta: variabile inserita dall'utente
         * \param   controllo: valore per il controllo, successivo al tentativo con una funzione TryParse
         * \brief   Viene visualizzato un menù per scelgliere le azioni da compiere
         * \details Viene visualizzata la stringa "-1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma.",
         * do alla variabile di tipo bool controllo il valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine,
         * restituisce il valore convertito in int e lo inserisce in scelta.
         * Inizia un ciclo while, se il controllo è falso o se la variabile scelta è minore di 0 o maggiore di 7, allora inizia il ciclo e viene mostrata
         * la stringa "Errato. -1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma.",
         * poi do alla variabile di tipo bool controllo il valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore 
         * convertito in int e lo inserisce in scelta, se il ciclo finisce allora viene ritornata la variabile scelta
         * \return  scelta: valore inserito dall'utente.
         */
        public static int menu_scelta()
        {
            int scelta;
            Console.WriteLine(" -1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma.");
            bool controllo = int.TryParse(Console.ReadLine(), out scelta);
            while (!controllo || (scelta < 0 || scelta > 7))
            {
                Console.WriteLine("Errato. -1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma.");
                controllo = int.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }


        /**
         * \fn      public static void sceltaElettrica(int scelta1)
         * \param   scelta2: serve per inserire la scelta fatta dall'utente
         * \param   CostoLuce: serve per inserire il costo della luce inserita dall'utente
         * \param   CostoGas: serve per inserire il costo della gas inserita dall'utente
         * \brief   Viene fatta una comparazione se lo strumento di partenza utilizza la luce.
         * \details Viene richiesto all'utente di inserire i prezzi del gas e della luce, poi si crea l'oggetto energia di tipo Luce, viene poi richiesto di inserire il mezzo da comparare attraverso la funzione menu_scelta(),
         * viene poi eseguito un controllo sulla non ugualietà dei valori di scelta1 e scelta2.
         * Succesivamente viene fatto un if, se scelta1 è uguale a 1, 2 o 5 allora si crea l'oggetto strumento2 di tipo StrumentiRiscaldamento, l'oggetto energiastrumento2 di tipo Luce e vengono comparati i prezzi restituti dalle classi, 
         * dicendo quale tra lo strumento di partenza e lo strumento comparato è più conveniente.
         * Se scelta1 è uguale a 3 o 4 allora si crea l'oggetto strumento2 di tipo StrumentiRiscaldamento, l'oggetto energiastrumento2 di tipo Gas e vengono comparati i prezzi restituti dalle classi, dicendo quale tra lo strumento di partenza 
         * e lo strumento comparato è più conveniente
         */
        public static void sceltaElettrica(int scelta1)
        {
            Console.WriteLine("Inserisci per la luce");
            double CostoLuce = RichiediCostoMateria();
            Console.WriteLine("Inserisci per il gas");
            double CostoGas = RichiediCostoMateria();
            Luce energia = new Luce(MateriaUtilizzata(), CostoLuce);
            StrumentiRiscaldamento pompadicalore = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta1, (energia.GetPotenzaNormale()));
            Console.WriteLine("Scegli il mezzo da comparare:");
            int scelta2 = menu_scelta();
            while (scelta1 == scelta2)
            {
                Console.WriteLine("Errore. Non puoi inserire lo stesso strumento");
                scelta2 = menu_scelta();
            }
            if (scelta2 == 1 || scelta2 == 2 || scelta2 == 5)
            {
                StrumentiRiscaldamento strumento2 = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta2, energia.GetPotenzaNormale());
                Luce energiastrumento2 = new Luce(strumento2.GetPotenzaEffettiva(), CostoLuce);
                if (pompadicalore.GetCosto(energia.TotaleLordo()) > strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene il secondo strumento inserito");

                }
                else if (pompadicalore.GetCosto(energia.TotaleLordo()) < strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene lo strumento di partenza");
                }
                else if (pompadicalore.GetCosto(energia.TotaleLordo()) == strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Le due soluzioni sono uguali");
                }
            }
            else if (scelta2 == 3 || scelta2 == 4)
            {
                StrumentiRiscaldamento strumento2 = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta2, energia.GetPotenzaLuceAGas());
                Gas energiastrumento2 = new Gas(strumento2.GetPotenzaEffettiva(), CostoGas);
                if (pompadicalore.GetCosto(energia.TotaleLordo()) > strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene il secondo strumento inserito");

                }
                else if (pompadicalore.GetCosto(energia.TotaleLordo()) < strumento2.GetCosto(energia.TotaleLordo()))
                {
                    Console.WriteLine("Coviene lo strumento di partenza");
                }
                else if (pompadicalore.GetCosto(energia.TotaleLordo()) == strumento2.GetCosto(energia.TotaleLordo()))
                {
                    Console.WriteLine("Le due soluzioni sono uguali");
                }
            }
        }

        /**
        * \fn      public static void sceltaGas(int scelta1)
        * \param   scelta2: serve per inserire la scelta fatta dall'utente
        * \param   CostoLuce: serve per inserire il costo della luce inserita dall'utente
        * \param   CostoGas: serve per inserire il costo della gas inserita dall'utente
        * \brief   Viene fatta una comparazione se lo strumento di partenza utilizza la luce.
        * \details Viene richiesto all'utente di inserire i prezzi del gas e della luce, poi si crea l'oggetto gas di tipo Gas, viene poi richiesto di inserire il mezzo da comparare attraverso la funzione menu_scelta(),
        * viene poi eseguito un controllo sulla non ugualietà dei valori di scelta1 e scelta2.
        * Succesivamente viene fatto un if, se scelta1 è uguale a 1, 2 o 5 allora si crea l'oggetto strumento2 di tipo StrumentiRiscaldamento, l'oggetto energiastrumento2 di tipo Luce e vengono comparati i prezzi restituti dalle classi, 
        * dicendo quale tra lo strumento di partenza e lo strumento comparato è più conveniente.
        * Se scelta1 è uguale a 3 o 4 allora si crea l'oggetto strumento2 di tipo StrumentiRiscaldamento, l'oggetto energiastrumento2 di tipo Gas e vengono comparati i prezzi restituti dalle classi, dicendo quale tra lo strumento di partenza 
        * e lo strumento comparato è più conveniente
        */
        public static void sceltaGas(int scelta1)
        {
            Console.WriteLine("Inserisci per la luce");
            double CostoLuce = RichiediCostoMateria();
            Console.WriteLine("Inserisci per il gas");
            double CostoGas = RichiediCostoMateria();
            Gas gas = new Gas(MateriaUtilizzata(), CostoGas);
            StrumentiRiscaldamento pompadicalore = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta1, (gas.GetPotenzaGasALuce()));
            Console.WriteLine("Scegli il mezzo da comparare:");
            int scelta2 = menu_scelta();
            while (scelta1 == scelta2)
            {
                Console.WriteLine("Errore. Non puoi inserire lo stesso strumento");
                scelta2 = menu_scelta();
            }
            if (scelta2 == 1 || scelta2 == 2 || scelta2 == 5)
            {
                StrumentiRiscaldamento strumento2 = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta2, gas.GetPotenzaGasALuce());
                Luce energiastrumento2 = new Luce(strumento2.GetPotenzaEffettiva(), CostoGas);
                if (pompadicalore.GetCosto(gas.TotaleLordo()) > strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene il secondo strumento inserito");

                }
                else if (pompadicalore.GetCosto(gas.TotaleLordo()) < strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene lo strumento di partenza");
                }
                else if (pompadicalore.GetCosto(gas.TotaleLordo()) == strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Le due soluzioni sono uguali");
                }
            }
            else if (scelta2 == 3 || scelta2 == 4)
            {
                StrumentiRiscaldamento strumento2 = new StrumentiRiscaldamento(RichiediCostoStrumento(), scelta2, gas.GetPotenzaGasALuce());
                Gas energiastrumento2 = new Gas(strumento2.GetPotenzaEffettiva(), CostoGas);
                if (pompadicalore.GetCosto(gas.TotaleLordo()) > strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene il secondo strumento inserito");

                }
                else if (pompadicalore.GetCosto(gas.TotaleLordo()) < strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Coviene lo strumento di partenza");
                }
                else if (pompadicalore.GetCosto(gas.TotaleLordo()) == strumento2.GetCosto(energiastrumento2.TotaleLordo()))
                {
                    Console.WriteLine("Le due soluzioni sono uguali");
                }
            }
        }

        /**
        * \fn      public static void menù()
        * \param   scelta1: serve per inserire la scelta fatta dall'utente, viene posta pari a -1
        * \brief   Va ad indirizzare la scelta fatta con la funzione menu_scelta.
        * \details Viene utilizzata all'inzio un Console.Clear(), poi inizia un ciclo do while, che si ripete fino a quando scelta non è uguale a 6, poi viene inserito in scelta1 il valore di ritorno della funzione menu_scelta(),
         * poi viene fatto un if, se scelta1 è uguale a 1, 2 o 5 allora si richiamerà la funzione sceltaElettrica(scelta1) oppure se scelta1 è uguale a 3 o 4 allora si richiamerà la funzione sceltaGas(scelta1).
        */
        public static void menù()
        {
            int scelta1 = -1;
            Console.Clear();
            do
            {
                Console.WriteLine("Scegli il mezzo di partenza:");
                scelta1 = menu_scelta();
                if (scelta1 == 1 || scelta1 == 2 || scelta1 == 5)
                    sceltaElettrica(scelta1);
                else if (scelta1 == 3 || scelta1 == 4)
                    sceltaGas(scelta1);
            } while (scelta1 != 6);
        }
    }
}
