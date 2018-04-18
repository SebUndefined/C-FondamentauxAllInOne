using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EventsPerso
{
    class Program
    {
        static void Main(string[] args)
        {
            Facturation facturation = new Facturation(true, true);
            facturation.CalculFactureTermine += Facturation.EnvoieparMail;
            facturation.CalculFactureTermine += Facturation.EnvoieparPoste;
            facturation.CalculFacture();
            Console.ReadLine();

        }

        
    }
}
