using System;

namespace Bollette
{
    class Program
    {
        static void Main(string[] args)
        {
            menù();
            Console.ReadKey();
        }

        /**
         * \fn      public static void menù()
         * \param   scelta: serve per inserire la scelta fatta dall'utente, viene posta pari a -1
         * \brief   Va ad indirizzare la scelta fatta con la funzione menu_scelta.
         * \details Viene utilizzata all'inzio un Console.Clear(), poi inizia un ciclo do while, che si ripete fino a quando scelta non è uguale a 5, poi viene inserito in scelta il valore di ritorno della funzione menu_scelta(),
         * poi viene fatto uno switch case con la variablie scelta, se scelta è uguale a 1 allora si richiama la funzione Inserisci_fantacalciatore(), se scelta è uguale a 2 allora si richiama la funzione Menù_aggiungi_punti(),
         * se scelta è uguale a 3 allora si richiama la funzione Banca_vendita(), a cui passo il valore di ritorno della funzione Id_Fantaallenatori(), a cui a sua volta passo il valore di ritorno della funzione Squadra() 
         * e se scelta è uguale a 4 allora si richiama la funzione Classifica_Punti()
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

        public static double RichiediCostoStrumento()
        {
            double scelta;
            Console.WriteLine("Inserisci il costo dello strumento.");
            bool controllo = double.TryParse(Console.ReadLine(), out scelta); //Inizializzo la variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            while (!controllo || (scelta < 0)) //Ciclo while, che si avvia se controllo è falso o se la variabile numero_squadre è minore di 0 o maggiore di 14.
            {
                Console.WriteLine("Errato. Inserisci il costo dello strumento."); //Scrive su console la stringa.
                controllo = double.TryParse(Console.ReadLine(), out scelta); //Do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            }
            return scelta;
        }

        public static double RichiediCostoMateria()
        {
            double scelta;
            Console.WriteLine("Inserisci il costo della materia prima.");
            bool controllo = double.TryParse(Console.ReadLine(), out scelta); //Inizializzo la variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            while (!controllo || (scelta < 0)) //Ciclo while, che si avvia se controllo è falso o se la variabile numero_squadre è minore di 0 o maggiore di 14.
            {
                Console.WriteLine("Errato. Inserisci il costo della materia prima."); //Scrive su console la stringa.
                controllo = double.TryParse(Console.ReadLine(), out scelta); //Do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            }
            return scelta;
        }

        public static void menù()
        {
            int scelta1 = -1; //Inizzializzo la avriabile di tipo int scelta e la pongo uguale a -1.
            Console.Clear(); //Funzione, che pulisce la console.

            do //Ciclo do while, che continua se la variabile di tipo int è diversa da 6.
            {
                Console.WriteLine("Scegli il mezzo di partenza:");
                scelta1 = menu_scelta();
                switch (scelta1) //Switch con la variabile scelta.
                {
                    case 1: //Se la variabile scelta è uguale a 1.
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
                        break; //Chiudo.    
                    case 2: //Se la variabile scelta è uguale a 2.
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
                        break; //Chiudo.    
                    case 3: //Se la variabile scelta è uguale a 3.
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
                        break; //Chiudo.    
                    case 4: //Se la variabile scelta è uguale a 4.
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
                        break; //Chiudo.    
                    case 5: //Se la variabile scelta è uguale a 5.
                        {
                            Console.WriteLine("Inserisci per la luce");
                            double CostoLuce = RichiediCostoMateria();
                            Console.WriteLine("Inserisci per il gas");
                            double CostoGas = RichiediCostoMateria();
                            Luce energia = new Luce(MateriaUtilizzata(), CostoLuce);
                            //Console.WriteLine("Inserisci per il gas"); +gas.GetPotenzaGasALuce()
                            //Gas gas = new Gas(MateriaUtilizzata(), CostoGas);
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
                        break; //Chiudo.
                }
            } while (scelta1 != 6);
        }

        /**
         * \fn      public static int menu_scelta()
         * \param   scelta: variabile inserita dall'utente
         * \param   controllo: valore per il controllo, successivo al tentativo con una funzione TryParse
         * \brief   Viene visualizzato un menù per scelgliere le azioni da compiere
         * \details Viene pulita la console, con un Console.Clear(), poi viene visualizzata la stringa "Menù:\n -1 Inserisci fanatcalciatori.\n -2 Inserisci punti.\n -3 Vendi fantacalciatore.\n -4 Mostra classifica.\n 
         * -5 Chiudi programma.", do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine,
         * restituisce il valore convertito in int e lo inserisce in scelta, inizia un ciclo while se controllo è falso o se la variabile numero_squadre è minore di 0 o maggiore di 14, se inizia allora viene mostrata
         * la stringa "Errato. Menù:\n -1 Inserisci fanatcalciatori.\n -2 Inserisci punti.\n -3 Vendi fantacalciatore.\n -4 Mostra classifica.\n -5 Chiudi programma.",
         * poi do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore 
         * convertito in int e lo inserisce in scelta, se il ciclo finisce allora viene ritornata la variabile scelta
         * \return  scelta: valore inserito dall'utente.
         */
        public static int menu_scelta()
        {
            int scelta;
            Console.WriteLine(" -1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma.");
            bool controllo = int.TryParse(Console.ReadLine(), out scelta); //Inizializzo la variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            while (!controllo || (scelta < 0 || scelta > 7)) //Ciclo while, che si avvia se controllo è falso o se la variabile numero_squadre è minore di 0 o maggiore di 14.
            {
                Console.WriteLine("Errato. -1 Pompa di calore.\n -2 Pompa di calore economica.\n -3 Caldaia tradizionale.\n -4 Caldaia a condensazione.\n -5 Stufa elettrica.\n -6 Chiudi programma."); //Scrive su console la stringa.
                controllo = int.TryParse(Console.ReadLine(), out scelta); //Do alla variabile di tipo bool controllo e le do valore pari al valore ritornato dalla funzione TryParse, che prende in entrata il valore preso dalla funzione Console.ReadLine, restituisce il valore convertito in int e lo inserisce in scelta.
            }
            return scelta; //Ritorna la variabile scelta.
        }

        double GetPotenza(int tipologia, float potenza)
        {
            if (tipologia == 0)
                return potenza;
            else if (tipologia == 1)
                return potenza * 10.7;

            return -1;
        }
    }
}
