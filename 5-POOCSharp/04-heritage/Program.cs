using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _04_heritage.ClasseAbstraite;

namespace _04_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne(3);
            Pilote pilote1 = new Pilote();
            pilote1.Experience = 5;
            pilote1.NbVictoire = 89;
            pilote1.Conduire_Override();
            Pilote pilote2 = new Pilote(3, 12);
            Console.WriteLine("Le pilote 2 a " + pilote2.Experience + " année d'expérience et a " + pilote2.NbVictoire + " victoire à son actif");

            //Redéfinition et masquage
            //Override permet de se baser sur le type concret de la variable
            Console.WriteLine("##########Redéfinition et masquage#################");

            Personne personne2 = new Personne();
            Pilote pilote3 = new Pilote();
            Personne personnePilote = new Pilote();

            personne2.Conduire_Override();
            pilote3.Conduire_Override();
            //Le type concret de personnePilote est Pilote, donc appel de Conduire_Override de Pilote
            personnePilote.Conduire_Override();

            Console.WriteLine("Avec le mot clé new");

            personne2.Conduire_New();
            pilote3.Conduire_New();
            //Avec le mot clé new, on casse l'arbre de recherche. Si la méthode dans la classe
            //Mère est marqué comme virtual, on commence la recherche dans la classe mère
            // Sinon on exécute la méthode de la classe manipulé. Ici Personne.
            personnePilote.Conduire_New();

            //Classes abstraite
            //Ligne suivante invalide
            //ClasseAbstraite classeAb = new ClasseAbstraite();
            ClasseDerive classeDerive = new ClasseDerive();
            classeDerive.MethodeAbstraite();

            //Transtypage
            Console.WriteLine("################Transtypage###################");
            short valeurShort = 12;
            //Transtypage, ici fonctionne
            int valeurInt = valeurShort;
            //Le pilote hérite de personne, il peut donc être trantypé
            Pilote piloteTrantype = new Pilote();
            Personne personneTranstype = piloteTrantype;

            //L'instruction suivante ne marche pas, nous devons faire un cast
            //int valeurIntTranstype = 42;
            //short valeurShortTranstype = valeurIntTranstype;
            int valeurIntTranstype = 42;
            short valeurShortTranstype = (short)valeurIntTranstype;



            Console.ReadLine();
        }
    }
}
