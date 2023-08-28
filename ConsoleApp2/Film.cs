using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Film
    {
        public string Titolo { get; set; }

        public string Genere { get; set; }

        public int AnnoDiUscita { get ; set; }

        public string Regista { get; set; }

        public void GetFilm()
        {
            Console.WriteLine(


                Titolo + " " +
                Genere + " " + 
                Regista + " " +
                AnnoDiUscita

                );
        }

    }
}
