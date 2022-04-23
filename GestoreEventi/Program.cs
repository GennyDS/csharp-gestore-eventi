using GestoreEventi;

List<Evento> ListaDiEventi= new List<Evento>();

Console.WriteLine("inserisci il Titolo dell'evento ");
string TitoloUtente=Console.ReadLine();


Console.WriteLine("inserisci la Data dell'evento ");
DateTime DataUtente=DateTime.Parse(Console.ReadLine());

Console.WriteLine("inserisci il Numero dei posti Massimi dell'evento ");
int nPostiMaxUtente = int.Parse(Console.ReadLine());


Console.WriteLine("inserisci il numero dei posti che intendi prenotare  ");
int nPostiPrenotatiUtente=int.Parse(Console.ReadLine());

//-------CREZIONE OGGETTO------
Evento mioEvento = new Evento(TitoloUtente, DataUtente, nPostiMaxUtente);
mioEvento.PrenotaPosti( nPostiPrenotatiUtente);


Console.WriteLine("Numero di posti prenotati: "+nPostiPrenotatiUtente);
Console.WriteLine("Numero di posti Disponibili: "+mioEvento.GetPostiDisponibili(nPostiPrenotatiUtente));


//-------PRENOTAZIONE-----------------
bool flagPrenotazione = false;

while (flagPrenotazione == false)
{

    Console.WriteLine("Vuoi Prenotare altri Posti ? (Si/No)");
    string RispostaUtentePrenotazione = Console.ReadLine();
    RispostaUtentePrenotazione = RispostaUtentePrenotazione.ToLower();


    if (RispostaUtentePrenotazione == "si")
    {
        Console.WriteLine("quanti posti vuole prenotare?");
        int numeroPostiDaPrenotare = int.Parse(Console.ReadLine());
        int nNuoviPostiPrenotati = mioEvento.PrenotaPosti(numeroPostiDaPrenotare);


        Console.WriteLine("Numero di posti prenotati: " + mioEvento.GetNPostiPrenotati());
        Console.WriteLine("Numero di posti Disponibili: " + mioEvento.GetPostiDisponibili(nNuoviPostiPrenotati));             
    }
    else if (RispostaUtentePrenotazione == "no")
    {
        Console.WriteLine("Ok VaBene!!");
        flagPrenotazione=true;

    }
    else if ((RispostaUtentePrenotazione !="si")   || (RispostaUtentePrenotazione != "no"))
    {
        throw new ArgumentOutOfRangeException("Hai inserito una risposta non contemplata,RIPROVA");
    }

}




//------DISDIRE-------
bool flagDisdire = false;


while(flagDisdire==false)
{

Console.WriteLine("Vuoi DISDIRE i posti ? (Si/No)");
    string RispostaUtenteDisdire = Console.ReadLine();
    RispostaUtenteDisdire=RispostaUtenteDisdire.ToLower();

    if (RispostaUtenteDisdire == "si")
    {
        Console.WriteLine("quanti posti vuoi disdire?");
        int numeroPostiDaDisdire = int.Parse(Console.ReadLine());
        int nPostiDisdetti = mioEvento.DisdiciPosti(numeroPostiDaDisdire);
       

       Console.WriteLine("Numero di posti prenotati: " + mioEvento.GetNPostiPrenotati());
        Console.WriteLine("Numero di posti Disponibili: " + mioEvento.GetPostiDisponibili(nPostiDisdetti));  

    }
        else if (RispostaUtenteDisdire =="no")
        {
      flagDisdire = true;
        }

}




//mioEvento.ToString();
























Console.WriteLine("inserisci il nome del tuo programma eventi");
 string NomeEventoUtente=Console.ReadLine();

Console.WriteLine("indica il numero di eventi da inserire");
int NumeroEventoUtente= int.Parse(Console.ReadLine());

