using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Facturation fact = new Facturation();
            fact.CalculFactureTermine += gestionnaire_CalculFactureTermine;
            fact.CalculFacture();
            Console.ReadLine();
        }
        private static void gestionnaire_CalculFactureTermine(object sender, EventArgs e)
        {
            Console.WriteLine("Le calcul de la facture est terminé");
        }
    }
}
