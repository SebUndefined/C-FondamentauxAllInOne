using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DeleguePerso
{
    class AffichageListe
    {
       
        public static void DonneesBrute(List<double> list)
        {
            foreach(double element in list)
            {
                Console.WriteLine(element);
            }
        }

        public static void DonneesMisEnForme(List<double> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("L'élément numéro :" + i + " à pour valeur:" + list[i]);
            }
        }

        public static void DonneesMisEnFormeLuxe(List<double> list)
        {
            Console.WriteLine("Bonjour, voici les données de votre liste :");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("\tL'élément numéro :" + i + " à pour valeur:" + list[i]);
            }
        }
    }
}
