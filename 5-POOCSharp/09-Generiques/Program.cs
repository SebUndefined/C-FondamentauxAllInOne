using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generiques
{
    class Program
    {
        static void Main(string[] args)
        {
            //On créé une instance de notre type générique !! 
            ListeFIFO<string> liste = new ListeFIFO<string>();
            Console.WriteLine(liste);

            ListeFIFO<int> listInt = new ListeFIFO<int>();
            listInt.AjouterElement(1);
            listInt.AjouterElement(2);
            listInt.AjouterElement(3);
            listInt.AjouterElement(4);
            int compteur = 0;
            Console.WriteLine("Liste de base");
            for (compteur = 0; compteur < listInt.TableauInterne.Length; compteur++)
            {
                Console.WriteLine(listInt.TableauInterne[compteur]);
            }
            listInt.EnleverParNumero(2);
            Console.WriteLine("Liste avec element supprimé");
            for (compteur = 0; compteur < listInt.TableauInterne.Length; compteur++)
            {
                Console.WriteLine(listInt.TableauInterne[compteur]);
            }
            listInt.EnleverElement();
            for (compteur = 0; compteur < listInt.TableauInterne.Length; compteur++)
            {
                Console.WriteLine(listInt.TableauInterne[compteur]);
            }

            //Evenements
            ListeFIFO<string> liste2 = new ListeFIFO<string>();

            liste2.AlerteNombreElements += liste_AlerteNombreElements;
            for (int i = 0; i < 10; i++)
            {
                liste2.AjouterElement("chaine " + 1);
            }
            Console.WriteLine("10 éléments sont dans la liste.");
            Console.WriteLine("Ajout d'un élément perturbateur...");

            liste2.AjouterElement("élément perturbateur");

            Console.ReadLine();
        }


        static void liste_AlerteNombreElements(string dernierElementAjoute)
        {
            Console.WriteLine("Il y a plus de 10 éléments dans la liste ! Le dernier est '{0}'", dernierElementAjoute);
        }
    }
}
