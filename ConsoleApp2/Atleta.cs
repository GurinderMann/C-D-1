using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Nazionalità { get; set; }

        public string Sport { get; set; }

        public void GetFullName() 
        { 
            Console.WriteLine (
                Nome + " " +
                Cognome + " " + 
                Nazionalità + " " +
                Sport 

                );
        }
    }


        
}
