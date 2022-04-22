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

        public Evento(string Titolo, DateTime Data, int CapienzaMaxEvento, int nPostiPrenotati)   //Costruttore
        {
            this.Titolo = Titolo;
            this.Data = Data = DateTime.Now; ;
           ;
            this.nPostiPrenotati = nPostiPrenotati=0;

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
            DateTime NuovaData=;
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




        public int  PrenotaPosti(int nPostiMaxUtente)
        {
            int NuoviPostiPrenotati;
            bool flag = false;

            do
            {

                Console.WriteLine("Inserisci il numero di posti che vuoi prenotare");
                NuoviPostiPrenotati = int.Parse(Console.ReadLine());

                NuoviPostiPrenotati += nPostiPrenotati;

                if (NuoviPostiPrenotati >nPostiMaxUtente)
                {
                    throw new Exception("Posti non disponibili,riprova");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

                return NuoviPostiPrenotati;
        }



        public int DisdiciPosti( int nPostiRimossi)
        {

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
