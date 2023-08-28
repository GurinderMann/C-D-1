using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente = new Dipendente();

            dipendente.Nome = "Mario";
            dipendente.Cognome = "Rossi";
            dipendente.Stipendio = 2000;
            dipendente.Bonus = 0.1;

            Console.WriteLine(dipendente.StipendioCompleto);
         
            Atleta atleta = new Atleta();

            atleta.Nome = "Usain";
            atleta.Cognome = "Bolt";
            atleta.Nazionalità = "Jamaica";
            atleta.Sport = "Atletica leggera";

            atleta.GetFullName();


            Animale animale = new Animale();

            animale.Nome = "Cane";
            animale.Specie = "Pitbull";

            Console.WriteLine(animale.Specie);

            Student student = new Student();

            student.Nome = "Giovanni";
            student.Età = 25;
            student.Corso = "Web-Developer";

            Console.WriteLine(student.Nome);    
            Console.WriteLine(student.Corso );

            Film film = new Film();

            film.Titolo = "Harry Potter e la pietra filosofale ";
            film.Genere = "fantastico, avventura";
            film.AnnoDiUscita = 2001;
            film.Regista = "Chris Columbus";

            film.GetFilm();
              
            Prodotto prodotto = new Prodotto();
            prodotto.Nome = "PS5";
            prodotto.Prezzo = 500;
            prodotto.Quantità = 2;

            prodotto.TotalPrice();

            Console.ReadLine();

        }
    }
}
