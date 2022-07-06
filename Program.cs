namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione evento
            Console.WriteLine("\n* Creazione evento *\n");
            Console.Write("Titolo: ");
            string titolo = Console.ReadLine();
            Console.Write("Data (gg/mm/yyyy): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Capienza massima: ");
            int capienzaMassima = Convert.ToInt32(Console.ReadLine());

            Evento evento = new Evento(titolo, data, capienzaMassima);


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
        }
    }
}