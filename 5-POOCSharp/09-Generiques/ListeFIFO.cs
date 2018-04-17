using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generiques
{
    //On définit notre type générique
    public class ListeFIFO<TElement> : IListeFIFO<TElement>
    {
        private TElement[] tableauInterne;

        public ListeFIFO()
        {
            this.tableauInterne = new TElement[0];
        }

        public TElement[] TableauInterne { get => tableauInterne; set => tableauInterne = value; }

        public void AjouterElement(TElement elementAAjouter)
        {
            if(tableauInterne.Length >= 10 )
            {
                this.DeclencheAlerteNombre(elementAAjouter);
            }
            //Lors de l'ajout d'un élément, on créé un nouveau tableau
            TElement[] tableauTemporaire = new TElement[tableauInterne.Length + 1];
            this.tableauInterne.CopyTo(tableauTemporaire, 0);
            //On rempli la dernière case du tableau tableauTemporaire (trouvé avec tableauInterne.Length
            //Avec l'élement en paramètre
            tableauTemporaire[tableauInterne.Length] = elementAAjouter;
            //On redéfini l'attribut tableau interne
            tableauInterne = tableauTemporaire;
        }



        public TElement EnleverElement()
        {
            TElement resultat = tableauInterne[0];
            TElement[] tableauTemporaire = new TElement[this.tableauInterne.Length - 1];

            for (int i = 1; i < tableauInterne.Length; i++)
            {
                tableauTemporaire[i - 1] = tableauInterne[i];
            }
            tableauInterne = tableauTemporaire;

            return resultat;

        }

        //Méthode générique
        public TResultat EnleverElement<TResultat>() where TResultat : TElement
        {
            TElement element = EnleverElement();
            TResultat resultat = (TResultat)element;
            return resultat;
        }



        public void EnleverParNumero(int index)
        {
            TElement[] tableauTemporaire = new TElement[this.tableauInterne.Length - 1];
            bool found = false;
            for(int i = 0; i < tableauInterne.Length; i++)
            {
                if(i != index)
                {
                    if(found)
                    {
                        tableauTemporaire[i - 1] = tableauInterne[i];
                    }
                    else
                    {
                        tableauTemporaire[i] = tableauInterne[i];
                    }
                }
                else
                {
                    found = true;
                }
                
            }
            tableauInterne = tableauTemporaire;
        }

        //On définit notre type délégué
        public delegate void GestionnaireAlerteNombre<TElementAjoute>(TElementAjoute dernierElementAjoute);
        //Cette variable est tu type "délégué" GestionnaireAlerteNombre<TElementAjoute>
        public event GestionnaireAlerteNombre<TElement> AlerteNombreElements;

        protected virtual void DeclencheAlerteNombre(TElement dernierElementAjoute)
        {
            GestionnaireAlerteNombre<TElement> handler = AlerteNombreElements;
            //Si un ou plusieurs gestionnaires sont définis,
            //handler ne sera pas null
            if (handler != null)
            {
                handler(dernierElementAjoute);
            }
        }
    }
}
