using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string Titolo { get; set; }
        List<Evento> eventi = new List<Evento>();



        //------COSTRUTTORE--------
        public ProgrammaEventi (string Titolo, List<Evento> eventi)
        {
            this.Titolo = Titolo;   
            this.eventi = eventi=eventi.ToList();
        }


      /*  public string AddEvento (Evento NuovoEvento)
        {
            
           eventi.Add(NuovoEvento);
        
        }*/







    }
}
