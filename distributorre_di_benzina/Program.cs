using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distributorre_di_benzina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            distributore_benzina distributore = new distributore_benzina("dkjfh2", "via caio", 100);//INFORMAZIONI inserite nel custrottore 
            int a = 0;
            Console.WriteLine("scegliere opzione");
            
            Console.WriteLine("1-caricare soldi");
            Console.WriteLine("2-impostare prezzo al litro");
            Console.WriteLine("3-riempire il distrributore");
            Console.WriteLine("4-erogare benzina");

            a = int.Parse(Console.ReadLine());
            if (a==1)
            {
                Console.WriteLine("quanti soldi vuoi caricare?");
                
                distributore.Denaro_caricato= int.Parse(Console.ReadLine());

                distributore.AggiungiDenaro(distributore.Denaro_caricato);//passo i dati nella funzione nella classe

            }
           if(a==2)
            {
                Console.WriteLine("immettere il prezzo al litro");
                distributore.Prezzo_litro= int.Parse(Console.ReadLine());
                Console.WriteLine("il prezzo al litro è di " +distributore.Prezzo_litro);

            }
           if(a==3)
            {
                Console.WriteLine("di quanto vuoi riempire il distributore ?");
                int litri= int.Parse(Console.ReadLine());

            }
           if(a==4)
            {
                int benzina_erogata = distributore.Denaro_caricato / distributore.Prezzo_litro;

            }
            
        }
    }
}
