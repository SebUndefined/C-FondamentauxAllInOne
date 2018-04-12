using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderEnum order1 = OrderEnum.done;
            if(order1 == OrderEnum.done)
            {
                Console.WriteLine("La commande est terminé");
            }

            OrderEnum orderChoosen = OrderEnum.undefined;
            Console.WriteLine("Choisissez le statut");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    orderChoosen = OrderEnum.pending;
                    break;
                case 1:
                    orderChoosen = OrderEnum.done;
                    break;
                case 2:
                    orderChoosen = OrderEnum.canceled;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Votre commande est maintenant " + orderChoosen);


            Console.ReadLine();
        }
    }
}
