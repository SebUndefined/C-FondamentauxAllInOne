using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_heritage
{
    class Pilote : Personne
    {
        private int nbVictoire;

        public Pilote()
        {
        }

        public Pilote(int nbVictoire, int experience) : base(experience)
        {
            this.nbVictoire = nbVictoire;
        }

        public int NbVictoire
        {
            get => nbVictoire;
            set => nbVictoire = value;
        }
        /// <summary>
        /// Redéfinition de la méthode conduire
        /// </summary>
        public override void Conduire_Override()
        {
            Console.WriteLine("Je conduit en allant le plus vite possible (Override Pilote)");
        }
        public new void Conduire_New()
        {
            Console.WriteLine("Je conduit en allant le plus vite possible (New Pilote)");
        }
    }
}
