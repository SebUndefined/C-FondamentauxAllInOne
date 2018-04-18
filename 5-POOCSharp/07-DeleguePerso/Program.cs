using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DeleguePerso
{
    class Program
    {
        public delegate void AfficherListe(List<double> liste);

        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            for(int i = 10; i <= 22; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("#######Données brutes");
            ExecuterAffichageListe(AffichageListe.DonneesBrute, list);
            Console.WriteLine("#######Données mis en forme");
            ExecuterAffichageListe(AffichageListe.DonneesMisEnForme, list);
            Console.WriteLine("#######Données mis en forme et option Luxe");
            ExecuterAffichageListe(AffichageListe.DonneesMisEnFormeLuxe, list);
            Console.ReadLine();
        }
        public static void ExecuterAffichageListe(AfficherListe methode, List<double> liste)
        {
            methode(liste);
        }
    }
}
