using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EventsPerso
{
    public delegate void CalculFactureTermineHandler(object sender, EventArgs e);

    class Facturation
    {
        public bool ParPoste { get; set; }
        public bool ParMail { get; set; }
        //On déclare notre évènement
        public event CalculFactureTermineHandler CalculFactureTermine;


        public Facturation(bool parPoste, bool parMail)
        {
            ParPoste = parPoste;
            ParMail = parMail;
        }

        public void CalculFacture()
        {
            Console.WriteLine("Génération de la facture...");
            for(int i = 0; i <= 100; i++)
            {
                int statut = i;
                Console.WriteLine(statut + " % effectué");
            }
            EventArgs e = new EventArgs();
            CalculFactureIsTermine(e);
        }

        protected virtual void CalculFactureIsTermine(EventArgs e)
        {
            CalculFactureTermineHandler handler = CalculFactureTermine;

            //Si un ou plusieurs gestionnaire sont définis
            //Handler ne sera pas null
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public static void EnvoieparPoste(object sender, EventArgs e)
        {
            Console.WriteLine("Impression facture en cours...");
        }
        public static void EnvoieparMail(object sender, EventArgs e)
        {
            Console.WriteLine("Envoie par mail en cours...");
        }
    }
}
