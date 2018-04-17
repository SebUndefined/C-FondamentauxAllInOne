using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            UtiliserArray();
            ContinuerScript();

            UtiliserArrayList();
            ContinuerScript();

            UtiliserListGenerique();
            ContinuerScript();

            UtiliserHashTable();
            ContinuerScript();

            UtiliserDictionary();
            ContinuerScript();

            UtiliserStack();
            ContinuerScript();

            UtiliserStackGenerique();
            ContinuerScript();

            UtiliserQueue();
            ContinuerScript();

            UtiliserQueueGenrique();
            ContinuerScript();

        }


        private static void ContinuerScript()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Appuyez pour continuer");
            Console.WriteLine("#####################");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Utilise un Array simple
        /// </summary>
        private static void UtiliserArray()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'un Array simple");
            Console.WriteLine("#####################");
            Array tableau = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                tableau.SetValue(i + 1, i);
            }
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Element :" + i + " vaut " + tableau.GetValue(i));
            }
        }

        /// <summary>
        /// Utilisation de ArrayList
        /// </summary>
        private static void UtiliserArrayList()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'un ArrayList");
            Console.WriteLine("#####################");
            ArrayList list = new ArrayList();
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité initiale de la liste: {0} ", list.Capacity);
            Console.WriteLine();

            Console.WriteLine("Ajout de 10 éléments à la liste");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine: " + i;
                list.Add(valeur);
            }
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
            Console.WriteLine("Les éléments présents dans la liste sont:");
            foreach(string element in list)
            {
                Console.WriteLine("\t{0}", element);
            }
            Console.WriteLine();
            Console.WriteLine("Ajout de 10 nouveaux éléments à la liste");

            for(int i = 10; i < 20; i++)
            {
                string valeur = "chaine:" + i;
                list.Add(valeur);
            }
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
            Console.WriteLine("Les éléments présents dans la liste sont:");
            foreach (string element in list)
            {
                Console.WriteLine("\t{0}", element);
            }
            Console.WriteLine();

            //Test transfert de variable
            string chaineIndex3 = (string)list[3];
            string chaineIndex4 = (string)list[4];
            string chaineIndex5 = (string)list[5];
            string chaineIndex6 = (string)list[6];

            Console.WriteLine("La chaine de l'index 3 a pour valeur {0}", chaineIndex3);
            Console.WriteLine("La chaine de l'index 4 a pour valeur {0}", chaineIndex4);
            Console.WriteLine("La chaine de l'index 5 a pour valeur {0}", chaineIndex5);
            Console.WriteLine("La chaine de l'index 6 a pour valeur {0}", chaineIndex6);
            Console.WriteLine();

            Console.WriteLine("Suppression des éléments aux index 3 et 4");
            list.RemoveRange(3, 4);

            chaineIndex3 = (string)list[3];
            chaineIndex4 = (string)list[4];
            chaineIndex5 = (string)list[5];
            chaineIndex6 = (string)list[6];

            Console.WriteLine("Les chaines aux emplacements 3, 4, 5, 6 sont '{0}', '{1}', '{2}' et '{3}'", chaineIndex3, chaineIndex4, chaineIndex5, chaineIndex6);

            Console.WriteLine();

            Console.WriteLine("Insertion de la chaine 'Element inséré' à l'index 3");
            list.Insert(3, "Element inséré");
            chaineIndex3 = (string)list[3];
            chaineIndex4 = (string)list[4];
            chaineIndex5 = (string)list[5];
            chaineIndex6 = (string)list[6];

            Console.WriteLine("Les chaines aux emplacements 3, 4, 5, 6 sont '{0}', '{1}', '{2}' et '{3}'", chaineIndex3, chaineIndex4, chaineIndex5, chaineIndex6);
            Console.WriteLine();

            Console.WriteLine("Suppression de tous les éléments de la liste");
            list.Clear();

            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
        }

        /// <summary>
        /// Utilisation d'une liste générique (typage fort)
        /// </summary>
        private static void UtiliserListGenerique()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'une Liste");
            Console.WriteLine("#####################");
            List<string> list = new List<string>();
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité initiale de la liste: {0} ", list.Capacity);
            Console.WriteLine();

            Console.WriteLine("Ajout de 10 éléments à la liste");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine: " + i;
                list.Add(valeur);
            }
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
            Console.WriteLine("Les éléments présents dans la liste sont:");
            foreach (string element in list)
            {
                Console.WriteLine("\t{0}", element);
            }
            Console.WriteLine();
            Console.WriteLine("Ajout de 10 nouveaux éléments à la liste");

            for (int i = 10; i < 20; i++)
            {
                string valeur = "chaine:" + i;
                list.Add(valeur);
            }
            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
            Console.WriteLine("Les éléments présents dans la liste sont:");
            foreach (string element in list)
            {
                Console.WriteLine("\t{0}", element);
            }
            Console.WriteLine();

            //Test transfert de variable
            string chaineIndex3 = list[3];
            string chaineIndex4 = list[4];
            string chaineIndex5 = list[5];
            string chaineIndex6 = list[6];

            Console.WriteLine("La chaine de l'index 3 a pour valeur {0}", chaineIndex3);
            Console.WriteLine("La chaine de l'index 4 a pour valeur {0}", chaineIndex4);
            Console.WriteLine("La chaine de l'index 5 a pour valeur {0}", chaineIndex5);
            Console.WriteLine("La chaine de l'index 6 a pour valeur {0}", chaineIndex6);
            Console.WriteLine();

            Console.WriteLine("Suppression des éléments aux index 3 et 4");
            list.RemoveRange(3, 4);

            chaineIndex3 = list[3];
            chaineIndex4 = list[4];
            chaineIndex5 = list[5];
            chaineIndex6 = list[6];

            Console.WriteLine("Les chaines aux emplacements 3, 4, 5, 6 sont '{0}', '{1}', '{2}' et '{3}'", chaineIndex3, chaineIndex4, chaineIndex5, chaineIndex6);

            Console.WriteLine();

            Console.WriteLine("Insertion de la chaine 'Element inséré' à l'index 3");
            list.Insert(3, "Element inséré");
            chaineIndex3 = list[3];
            chaineIndex4 = list[4];
            chaineIndex5 = list[5];
            chaineIndex6 = list[6];

            Console.WriteLine("Les chaines aux emplacements 3, 4, 5, 6 sont '{0}', '{1}', '{2}' et '{3}'", chaineIndex3, chaineIndex4, chaineIndex5, chaineIndex6);
            Console.WriteLine();

            Console.WriteLine("Suppression de tous les éléments de la liste");
            list.Clear();

            Console.WriteLine("Nombre d'element dans la liste : {0} ", list.Count);
            Console.WriteLine("Capacité de la liste: {0} ", list.Capacity);
        }

        /// <summary>
        /// Utilisation d'une HashTable
        /// </summary>
        private static void UtiliserHashTable()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'une HashTable");
            Console.WriteLine("#####################");
            Hashtable collection = new Hashtable();
            Console.WriteLine("Le nombre d'élément initial est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for(int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                collection.Add(i, valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("Les éléments dans la collection sont:");
            foreach(int identifiant in collection.Keys)
            {
                string valeur = (string)collection[identifiant];
                Console.WriteLine("\tClé: {0} - Valeur : {1}", identifiant, valeur);
            }

            Console.WriteLine();

            Console.WriteLine("Suppression d'un élément dont la clé est 3");
            collection.Remove(3);

            bool cleExist;

            if(collection.ContainsKey(3))
            {
                cleExist = true;
            }
            else
            {
                cleExist = false;
            }

            Console.WriteLine("La clé 3 existe t'elle: {0}" + cleExist);
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("Suppression de tous les éléments");
            collection.Clear();
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

        }

        /// <summary>
        /// Utilisation de Dictionary (Typage fort)
        /// </summary>
        private static void UtiliserDictionary()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'un Dictionnary");
            Console.WriteLine("#####################");
            Console.WriteLine();
            Dictionary<int, string> collection = new Dictionary<int, string>();
            Console.WriteLine("Le nombre d'élément initial est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                collection.Add(i, valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("Les éléments dans la collection sont:");
            foreach (int identifiant in collection.Keys)
            {
                string valeur = collection[identifiant];
                Console.WriteLine("\tClé: {0} - Valeur : {1}", identifiant, valeur);
            }

            Console.WriteLine();

            Console.WriteLine("Suppression d'un élément dont la clé est 3");
            collection.Remove(3);

            bool cleExist;

            if (collection.ContainsKey(3))
            {
                cleExist = true;
            }
            else
            {
                cleExist = false;
            }

            Console.WriteLine("La clé 3 existe t'elle: {0}" + cleExist);
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

            Console.WriteLine("Suppression de tous les éléments");
            collection.Clear();
            Console.WriteLine("Le nombre d'élément est de {0}", collection.Count);
            Console.WriteLine();

        }

        //LIFO
        /// <summary>
        /// Utiliser Stack 
        /// </summary>
        private static void UtiliserStack()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'un Stack");
            Console.WriteLine("#####################");
            Console.WriteLine();

            Stack stack = new Stack();
            Console.WriteLine("Le nombre d'élément initial est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                stack.Push(valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("Récupération de l'element au dessus de la pile");
            string lastString = (string)stack.Peek();
            Console.WriteLine(lastString);

            Console.WriteLine("Suppression du dernier élément de la pile");
            stack.Pop();

            Console.WriteLine("Le nombre d'élément est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("Récupération de l'element au dessus de la pile");
            lastString = (string)stack.Peek();
            Console.WriteLine(lastString);

        }
        /// <summary>
        /// Utiliser Stack generique
        /// </summary>
        private static void UtiliserStackGenerique()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'un Stack generique (typage fort)");
            Console.WriteLine("#####################");
            Console.WriteLine();

            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Le nombre d'élément initial est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                stack.Push(valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("Récupération de l'element au dessus de la pile");
            string lastString = stack.Peek();
            Console.WriteLine(lastString);

            Console.WriteLine("Suppression du dernier élément de la pile");
            stack.Pop();

            Console.WriteLine("Le nombre d'élément est de {0}", stack.Count);
            Console.WriteLine();

            Console.WriteLine("Récupération de l'element au dessus de la pile");
            lastString = stack.Peek();
            Console.WriteLine(lastString);

        }

        //FIFO
        /// <summary>
        /// Utilisation d'une queue
        /// </summary>
        private static void UtiliserQueue()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'une file d'attente FIFO");
            Console.WriteLine("#####################");
            Console.WriteLine();

            Queue queue = new Queue();
            Console.WriteLine("Le nombre d'élément initial est de {0}", queue.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                queue.Enqueue(valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", queue.Count);
            Console.WriteLine();

            Console.WriteLine("Récupérer le premier element de la file sans le supprimer");
            string firstChaine = (string)queue.Peek();
            Console.WriteLine("Le premier élément de la file est {0}", firstChaine);

            Console.WriteLine("Récupérer le premier element de la file en le supprimant");
            string firstChaineForDelete = (string)queue.Dequeue();
            Console.WriteLine("Le premier élément de la file est {0}", firstChaineForDelete);

            Console.WriteLine("Le nombre d'élément est de {0}", queue.Count);
            Console.WriteLine();
        }

        private static void UtiliserQueueGenrique()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Utilisation d'une file d'attente FIFO generique (typage fort)");
            Console.WriteLine("#####################");
            Console.WriteLine();

            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Le nombre d'élément initial est de {0}", queue.Count);
            Console.WriteLine();

            Console.WriteLine("On ajoute 10 éléments");
            for (int i = 0; i < 10; i++)
            {
                string valeur = "chaine " + i;
                queue.Enqueue(valeur);
            }
            Console.WriteLine("Le nombre d'élément est de {0}", queue.Count);
            Console.WriteLine();

            Console.WriteLine("Récupérer le premier element de la file sans le supprimer");
            string firstChaine = queue.Peek();
            Console.WriteLine("Le premier élément de la file est {0}", firstChaine);

            Console.WriteLine("Récupérer le premier element de la file en le supprimant");
            string firstChaineForDelete = queue.Dequeue();
            Console.WriteLine("Le premier élément de la file est {0}", firstChaineForDelete);

            Console.WriteLine("Le nombre d'élément est de {0}", queue.Count);
            Console.WriteLine();
        }
    }
}
