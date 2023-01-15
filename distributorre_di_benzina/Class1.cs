using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distributorre_di_benzina
{

    internal class distributore_benzina
    {
        private string _numero_seriale;
        private string _indirizzo;
        private int _capacita_massima; // la quantita massima di benzina che può contenere il distributore 
        private int _livello_benzina; // la quantita di benzina presente in questo momento 
        private int _denaro_caricato;
        private int _prezzo_litro;

        public string Numero_seriale { get { return _numero_seriale; } private set { _numero_seriale = value; } }
        public string Indirizzo { get { return _indirizzo; } set { _indirizzo = value; } }
        public int Capacita_massima { get { return _capacita_massima; } private set { _capacita_massima = value; } }
        public int Livello_benzina { get { return _livello_benzina; } set { _livello_benzina = value; } }
        public int Denaro_caricato { get { return _denaro_caricato; } set { _denaro_caricato = value; } }
        public int Prezzo_litro { get { return _prezzo_litro; } set { _prezzo_litro = value; } }
        public distributore_benzina (string _numero_seriale, string _indirizzo, int _capacita_massima) // costruttore dove vanno dichiarate le variabili che non possono essere cambiate dal utente
        {
            Numero_seriale = _numero_seriale;
            Indirizzo = _indirizzo;
            Capacita_massima = _capacita_massima;
            
            
        } 
            
        public void AggiungiDenaro(int Denaro_caricato )
        {

            Denaro_caricato = Denaro_caricato;
            
            
            ControlloDenaro(Denaro_caricato);
            
        }
        
        public void ControlloDenaro(int Denaro_caricato) 
        { 
            if (Denaro_caricato >= 5 && Denaro_caricato <= 100)
            {
                
            }
            else
            {
                
                throw new Exception("inserire credito maggiore di 5 ma minore di 100"); //non fa proseguire l'utente 
            }
            

           
        }

        public void ControlloRiempireDistributore(int Capacita_massima, int litri)
        {
            

        }

        public void ControlloLivelloBenzinaErogazione(int benzina_erogata)
        {
            int a = 0;
            if(Livello_benzina==0 && a==0)
            {
                Livello_benzina = Capacita_massima;
                 a = 1;
            }
            
            Livello_benzina= Livello_benzina - benzina_erogata;

            if(Livello_benzina<0)
            {
                throw new Exception("siamo spiacenti ma il distributore non ha abbastana benzina ");

            }

            if(benzina_erogata==0)
            {
                throw new Exception("verificare se si ha inserito il denaro e se si ha impostato il prezzo a litro ");
            }
            Console.WriteLine(Livello_benzina);

        }










    }
    
}
