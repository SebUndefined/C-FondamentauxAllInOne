using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Facturation fact = new Facturation();
            fact.CalculFacture();
            Console.ReadLine();
        }
    }
}
