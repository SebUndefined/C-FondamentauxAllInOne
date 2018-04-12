using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_heritage
{
    //Classe abstraite, ne peut être instancier!!!
    public abstract class ClasseAbstraite
    {
        public abstract void MethodeAbstraite();
        

        public class ClasseDerive : ClasseAbstraite
        {
            //On est obligé de redéfinir la méthode ou de la masquer
            public override void MethodeAbstraite()
            {
                Console.WriteLine("La méthode abstraite dans la classe dérivé");
            }
        }
    }
}
