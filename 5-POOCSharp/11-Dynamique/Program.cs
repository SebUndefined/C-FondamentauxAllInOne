using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Dynamique
{
    class Program
    {
        static void Main(string[] args)
        {
            int entier1 = 10;
            int entier2 = 20;
            var resultatAddition = Additionner(entier1, entier2);
            Console.WriteLine("Le résultat de la fonction additionner est " + resultatAddition + " et son type est " + resultatAddition.GetType());

            string chaine1 = "Hello";
            string chaine2 = " world !";
            var concatChaine = chaine1 + chaine2;
            Console.WriteLine("Le résultat de la fonction additionner est " + concatChaine + " et son type est " + concatChaine.GetType());

            DateTime aujourdhui = DateTime.Today;
            DateTime hier = DateTime.Today.AddDays(-1);
            try
            {
                var date = Additionner(aujourdhui, hier);
                Console.WriteLine("Le résultat de la fonction additionner est " + date + " et son type est " + date.GetType());
            }
            catch (RuntimeBinderException e)
            {

                Console.WriteLine("Exception levée. Code: " + e.GetHashCode() + " Message: " + e.Message);
            }

            
            Console.ReadLine();
        }

        private static dynamic Additionner(dynamic operande1, dynamic operande2)
        {
            var resultat = operande1 + operande2;
            return resultat;
        }
    }
}
