﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesEtStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création d'un objet
            Voiture voiture1 = new Voiture("Peugeot", "208", 0);
            Console.WriteLine("La voiture1 est une " + voiture1.brand + " " + voiture1.model + " est à " + voiture1.kilometer + " km.");

            //Connaitre la mémoire utilisé par une app
            long memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine("Memory used " + memoryUsed + " Bytes");

            /*
            Différence entre classe et structure
            Une classe est de type référence
            Une structure est de type valeur
             */
            Voiture voiture2;
            //La ligne ci-dessous produit une erreur voiture 2 vaut null !!! 
            //voiture2.brand = "Test";

            voiture2 = new Voiture("Citroen", "ZX", 300000);

            StructVoiture structVoiture1;
            //Contrairement à au dessus, nous pouvons définir les attributs directement, c'est une strucutre et donc un type valeur
            structVoiture1.brand = "StructCitroen";
            structVoiture1.model = "StructZX";
            structVoiture1.kilometer = 3000000;

            Console.WriteLine("La structVoiture1 est une " + structVoiture1.brand + " " + structVoiture1.model + " est à " + structVoiture1.kilometer + " km.");


            StructVoiture structVoiture2 = structVoiture1;
            Voiture voitureCopy = voiture2;

            voitureCopy.kilometer = 400000;
            structVoiture2.kilometer = 400000;

            //On constate que lors d'une classe, on travaille sur le même objet en cas de copy simple contrairement au structs
            Console.WriteLine("Check after copy and modify");

            Console.WriteLine("La structVoiture1 est une " + structVoiture1.brand + " " + structVoiture1.model + " est à " + structVoiture1.kilometer + " km.");
            Console.WriteLine("La structVoiture2 est une " + structVoiture2.brand + " " + structVoiture2.model + " est à " + structVoiture2.kilometer + " km.");
            Console.WriteLine("La voiture2 est une " + voiture2.brand + " " + voiture2.model + " est à " + voiture2.kilometer + " km.");
            Console.WriteLine("La voitureCopy est une " + voitureCopy.brand + " " + voitureCopy.model + " est à " + voitureCopy.kilometer + " km.");

            voiture1.Demarrer();
            Console.WriteLine(voiture1.IsStarted());
            Console.WriteLine(voiture2.IsStarted());

            //Methode Opérateur: permet de redéfinir le comportement des opérateurs (+ - * etc...)
            CollectionDeTimbres collection1, collection2, resultatDesDeuxCollections;
            collection1.nombreDeTimbre = 40;
            collection1.prixEstime = 500;

            collection2.nombreDeTimbre = 40;
            collection2.prixEstime = 1000;

            resultatDesDeuxCollections = collection1 + collection2;

            Console.WriteLine("La nouvelle collection de timbres vaut " + resultatDesDeuxCollections.prixEstime + " euros, et est composée de " + resultatDesDeuxCollections.nombreDeTimbre + " timbres");


            //Propriété

            Console.ReadLine();
        }
    }
}
