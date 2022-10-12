using System;

namespace ConsoleApp1
{

   
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire cp = new CompteBancaire("ali becha",2500);
            cp.afficheInfoClient();
            cp.NomClient = "achref";
            cp.SoldeClient = 2500;

        }
    }
}
