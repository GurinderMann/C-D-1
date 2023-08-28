using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Prodotto
    {
        public string Nome { get; set; }
        public decimal Prezzo { get; set;}
        public int Quantità { get; set;}

        public void TotalPrice ()
        {
            Console.WriteLine(

                Prezzo * Quantità

                );
        }
    }
}
