using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generiques
{
    public interface IListeFIFO<TElement>
    {
        void AjouterElement(TElement elementAAjouter);

        TElement EnleverElement();
    }
}
