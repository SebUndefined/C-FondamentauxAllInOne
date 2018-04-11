using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesEtStructures
{
    class Client
    {
        private string name;
        private int age;

        //Raccourcis si aucune vérification
        public string Name{ get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value > this.age)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Une personne ne peut perdre en age !!! ");
                }
            }
        }
    }
}
