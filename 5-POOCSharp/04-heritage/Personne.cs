using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_heritage
{
    class Personne
    {
        protected int experience;

        public Personne()
        {
        }

        public Personne(int experience)
        {
            this.experience = experience;
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                this.experience = value;
            }
        }

        /// <summary>
        /// Methode conduire, elle peut être redéfini dans des classes enfant
        /// </summary>
        public virtual void Conduire_Override()
        {
            Console.WriteLine("Je conduit en respectant le code de la route(Override)");
        }
        public virtual void Conduire_New()
        {
            Console.WriteLine("Je conduit en respectant le code de la route(New)");
        }
    }
}
