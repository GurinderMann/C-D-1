using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dipendente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        private double _stipendio;

        public double Stipendio
        {
            get
            {
                return _stipendio;
            }
            set
            {
                _stipendio = value;
            }

        }

        public string FullName
        {
            get 
            {
                return Nome + " " + Cognome;
             }
        }

        public double Bonus { get; set; }

        public double StipendioCompleto
        {
            get
            {
                return _stipendio + (Stipendio * Bonus) ;
            }
        }

    }

}
