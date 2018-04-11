using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesEtStructures
{
    struct CollectionDeTimbres
    {
        public int nombreDeTimbre;
        public int prixEstime;

        //On redéfinit l'opérateur +
        public static CollectionDeTimbres operator +(CollectionDeTimbres collection1, CollectionDeTimbres collection2)
        {
            CollectionDeTimbres result;
            result.nombreDeTimbre = collection1.nombreDeTimbre + collection2.nombreDeTimbre;
            result.prixEstime = collection1.prixEstime + collection2.prixEstime;
            return result;
        }
    }
}
