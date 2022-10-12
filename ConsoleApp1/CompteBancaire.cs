using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CompteBancaire
    {
        public string NomClient { get; set; }
        public Double SoldeClient { get; set; }

        public CompteBancaire( string nom, double salaire)
        {
            this.NomClient= nom;
            this.SoldeClient= salaire;
        }

        public void afficheInfoClient ()
        {
            Console.WriteLine(NomClient);
            Console.WriteLine(SoldeClient);

        }

    }
}
