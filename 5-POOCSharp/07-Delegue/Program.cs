using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Delegue
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultat1 = ExecuterOperationMathematique(Additionner, 143, 18);
            Console.WriteLine(resultat1);
            double resultat2 = ExecuterOperationMathematique(Multiplier, 3, 2);
            Console.WriteLine(resultat2);
            //With Lambda expression
            OperationMathematique operation = (op1, op2) => { return op1 + op2; };
            double resultat3 = ExecuterOperationMathematique(operation, 143, 18);
            Console.WriteLine(resultat3);
            OperationMathematique operation2 = (op1, op2) => { return op1 * op2; };
            double resultat4 = ExecuterOperationMathematique(operation2, 6, 2);
            Console.WriteLine(resultat4);
            Console.ReadLine();
        }

        //On déclare notre delegate
        public delegate double OperationMathematique(double operande1, double operande2);

        //On déclare une fonction additionner
        private static double Additionner(double operande1, double operande2)
        {
            return operande1 + operande2;
        }
        //On peut en déclarer plusieurs
        private static double Multiplier(double operande1, double operande2)
        {
            return operande1 * operande2;
        }

        private static double ExecuterOperationMathematique(OperationMathematique operation, double operande1, double operande2)
        {
            return operation(operande1, operande2);
        }

    }
}
