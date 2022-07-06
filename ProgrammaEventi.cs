using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        private string titolo;

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public List<Evento> Eventi { get; set; }

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }

        public List<Evento> ListaEventiPerData(DateTime data)
        {
            List<Evento> eventiFiltrati = new List<Evento>();

            foreach(Evento evento in Eventi)
            {
                if(DateTime.Compare(evento.Data, data) == 0)
                {
                    eventiFiltrati.Add(evento);
                }
            }

            return eventiFiltrati;
        }

        public static string ListaEventi(List<Evento> eventi)
        {
            string esito = "";

            foreach(Evento evento in eventi)
            {
                esito += "\n" + evento.ToString();
            }

            return esito;
        }

        public int ContaEventi()
        {
            return Eventi.Count;
        }

        public void EliminaEventi()
        {
            Eventi.Clear();
        }

        public string DettaglioProgramma()
        {
            return Titolo + ":\n" + ListaEventi(Eventi);
        }
    }
}
