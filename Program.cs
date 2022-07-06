namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione evento
            /*Evento evento = Evento.CreaEvento();


            // Prenotazione
            try
            {
                Console.Write("\nVuoi effettuare delle prenotazioni? (s/n): ");
                string input = Console.ReadLine();

                if (input == "s")
                {
                    Console.Write("\nQuante prenotazioni vuoi effettuare? ");
                    int numPrenotazioni = Convert.ToInt32(Console.ReadLine());
                    evento.PrenotaPosti(numPrenotazioni);
                    //Console.Write("\nPrenotazione effettuata con successo!");
                }
                else if(input != "n")
                {
                    throw new Exception("Input errato.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // Stampa prenotazioni
            evento.StampaPosti();


            // Disdetta
            try
            {
                Console.Write("\nVuoi disdire delle prenotazioni? (s/n): ");
                string input = Console.ReadLine();

                if (input == "s")
                {
                    Console.Write("\nQuante prenotazioni vuoi disdire? ");
                    int numDisdette = Convert.ToInt32(Console.ReadLine());
                    evento.DisdiciPosti(numDisdette);
                    //Console.Write("\nDisdetta effettuata con successo!");
                }
                else if (input != "n")
                {
                    throw new Exception("Input errato.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // Stampa prenotazioni
            evento.StampaPosti();

            Console.WriteLine("\n" + evento.ToString());
            */

            Console.WriteLine("\n* Creazione programma eventi *\n");
            Console.Write("Titolo: ");
            string titoloProgramma = Console.ReadLine();

            ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);

            Console.Write("\nQuanti eventi vuoi creare? ");
            int numeroEventi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numeroEventi; i++)
            {
                // crea evento
                try
                {
                    Evento nuovoEvento = Evento.CreaEvento();
                    programma.Eventi.Add(nuovoEvento);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("\nInserimento eventi completato!");

            Console.WriteLine($"\nNumero di eventi: {programma.ContaEventi()}");

            Console.WriteLine("\n" + programma.DettaglioProgramma());

            Console.Write("\nInserisci una data (gg/mm/yyyy): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            List<Evento> listaFiltrata = programma.ListaEventiPerData(data);
            Console.WriteLine(ProgrammaEventi.ListaEventi(listaFiltrata));

            programma.EliminaEventi();
            Console.WriteLine("\nEventi eliminati.");
        }
    }
}