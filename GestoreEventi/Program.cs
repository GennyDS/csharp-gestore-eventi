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



int nPostiDisponibiliUtente = nPostiMaxUtente - nPostiPrenotatiUtente;

//-------------CONTROLLO POSTI---------
if(nPostiDisponibiliUtente <0)
{
    throw new ArgumentOutOfRangeException("Numero negativo");
}




//-------CREZIONE OGGETTO------
Evento mioEvento = new Evento(TitoloUtente, DataUtente, nPostiMaxUtente, nPostiPrenotatiUtente);


Console.WriteLine("Numero di posti prenotati: "+nPostiPrenotatiUtente);
Console.WriteLine("Numero di posti Disponibili: " +nPostiDisponibiliUtente);

//-----------------------------------------------

//-------CONTROLLO RISPOSTA UTENTE---------
bool flag = false;

while (flag == false)
{

    Console.WriteLine("Vuoi Prenotare altri Posti ? (Si/No)");
    string RispostaUtente = Console.ReadLine();
    RispostaUtente = RispostaUtente.ToLower();

    if (RispostaUtente == "si")
    {
        int nNuoviPostiPrenotati = mioEvento.PrenotaPosti(nPostiMaxUtente);

        nNuoviPostiPrenotati += nPostiPrenotatiUtente;
        int nNuoviPostiDisponibili = nPostiMaxUtente - nNuoviPostiPrenotati;

        Console.WriteLine("Numero di posti prenotati: " + nNuoviPostiPrenotati);
        Console.WriteLine("Numero di posti Disponibili: " + nNuoviPostiDisponibili);               //EROORE SULL'INSERIMENTO DEI NUMERI DOPO IL SECONDO SI (deve essere obbligatoriaamnete  più grande)

    }
    else if (RispostaUtente == "no")
    {
        Console.WriteLine("Ok VaBene!!");
        flag=true;

    }
    else
    {
        throw new ArgumentOutOfRangeException("Hai inserito una risposta non contemplata,RIPROVA");
    }
}


