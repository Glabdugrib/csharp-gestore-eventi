using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        public string Titolo
        {
            get
            {
                return this.Titolo;
            }

            set
            {
                try
                {
                    if (value != "")
                    {
                        this.Titolo = value;
                    }
                    else
                    {
                        throw new Exception("Il titolo non può essere vuoto.");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public DateTime Data
        {
            get
            {
                return this.Data;
            }

            set
            {
                try
                {
                    if (DateTime.Compare(value, DateTime.Now) >= 0)
                    {
                        this.Data = value;
                    }
                    else
                    {
                        throw new Exception("La data non può essere nel passato.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int CapienzaMassima
        {
            get
            {
                return this.CapienzaMassima;
            }

            private set
            {
                try
                {
                    if (value > 0)
                    {
                        this.CapienzaMassima = value;
                    }
                    else
                    {
                        throw new Exception("La capienza massima dev'essere un numero positivo.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int NumPostiPrenotati { get; private set; }

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            CapienzaMassima = capienzaMassima;
            NumPostiPrenotati = 0;
        }

        public void PrenotaPosti(int numPosti)
        {
            try
            {
                if(DateTime.Compare(Data, DateTime.Now) >= 0)
                {
                    if ((CapienzaMassima - NumPostiPrenotati) >= numPosti)
                    {
                        //prenota
                        NumPostiPrenotati += numPosti;
                    }
                    else
                    {
                        throw new Exception("Non ci sono più posti disponibili.");
                    }
                }
                else
                {
                    throw new Exception("L'evento è concluso.");
                }
            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }
        }

        public void DisdiciPosti(int numPosti)
        {
            try
            {
                if (DateTime.Compare(Data, DateTime.Now) >= 0)
                {
                    if (NumPostiPrenotati >= numPosti)
                    {
                        //prenota
                        NumPostiPrenotati -= numPosti;
                    }
                    else
                    {
                        throw new Exception("Non ci sono prenotazioni da disdire sufficienti.");
                    }
                }
                else
                {
                    throw new Exception("L'evento è concluso.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") + " - " + Titolo;
        }
    }
}
