using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Events
{
    class Facturation
    {
        //On déclare l'evenement
        public event EventHandler CalculFactureTermine;

        public void CalculFacture()
        {
            //Code potentiellement long
            //On simule cela en incrénetant i jusqu'à 1000
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Génération de la facture stade : " + i);
            }
            //On déclenche l'évènement
            EventArgs args = new EventArgs();
            DeclencheCalculFactureTermine(args);
        }

        protected virtual void DeclencheCalculFactureTermine(EventArgs e)
        {
            EventHandler handler = CalculFactureTermine;

            //Si un ou plusieurs gestionnaire sont définis
            //Handler ne sera pas null
            if(handler != null)
            {
                handler(this, e);
            }
        }
    }
}
