using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string Titolo;
        private DateTime Data;
        private int CapienzaMaxEvento;
        private int nPostiPrenotati;

        public Evento(string Titolo, DateTime Data, int CapienzaMaxEvento)   //Costruttore
        {
            this.Titolo = Titolo;

            if (Data < DateTime.Now)
            {
                throw new Exception("La data è  troppo vecchia");
            }

            this.Data = Data; 
            this.nPostiPrenotati = 0;
            this.CapienzaMaxEvento = CapienzaMaxEvento;

        }


        public string GetTitolo()
        {
            return Titolo;
        }
        public string ModificaTitolo()
        {
            bool flag = false;
            string NuovoTitolo="";
            do 
            {

               Console.WriteLine("Inserisci un nuovo titolo");
                NuovoTitolo=Console.ReadLine();
                 if(NuovoTitolo==null)
                 {
                         throw new Exception("il titolo non può essere vuoto");
                 }
                else
                {
                    flag=true;
                }
            }while(flag==false);

            return NuovoTitolo;
        }


        public DateTime GetData()
        {
            return Data;
        }


        /*
        public DateTime ModificaData()
        {
            DateTime NuovaData; 
            int flag=0;
            while (flag==0)
            {


                Console.WriteLine("Inserisci una nuova data");
                NuovaData = DateTime.Parse(Console.ReadLine());

                if (NuovaData < Data)
                {
                    throw new Exception("La Data è Gia Passata,riprova");
                }
                else if ((NuovaData > Data) || (NuovaData == Data))
                {
                    
                    flag =1;
               
                }
                return NuovaData;
            }
           


        }
        */


        public int  GetCapienzaMaxEvento()
        {
            return CapienzaMaxEvento;
        }


        public int  GetNPostiPrenotati()
        {
            return nPostiPrenotati;
        }

        public int GetPostiDisponibili(int numeroPostiPrenotati)
        {
            int postiDisponibili = this.CapienzaMaxEvento - numeroPostiPrenotati;
            return postiDisponibili;
        }


        public int  PrenotaPosti(int numeroPostiCheStoPrenotando)
        {

            bool flag = false;

            do
            {


                if (this.nPostiPrenotati<this.CapienzaMaxEvento)
                {
                this.nPostiPrenotati = this.nPostiPrenotati + numeroPostiCheStoPrenotando;
                    return this.nPostiPrenotati;
                    flag = true;
                    
                }
                  
                else
                {
                    throw new Exception("non ci sono abbastanza posti liberi");
                }
               

            } while (flag == false);
          

        }



        public int DisdiciPosti( int nPostiPrenotati)
        {
            int nPostiRimossi=0;
            bool flag = false;

            while (flag == false)
            {

                 Console.WriteLine("Inserisci il numero di posti che vuoi disdire");
                 nPostiRimossi= int.Parse(Console.ReadLine());
                nPostiRimossi -= nPostiPrenotati;

                if(nPostiRimossi>nPostiPrenotati)
                {
                    throw new Exception("il numero dei posti rimossi è maggiore dei posti prenotati");
                }
                else
                {
                    flag = true;
                }
            }
            return nPostiRimossi;
        }

        public virtual string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "---- Evento ---- \n";
            rappresentazioneInStringa += this.Data + "--"+this.Titolo;
            

            return rappresentazioneInStringa;
        }












    }
}
