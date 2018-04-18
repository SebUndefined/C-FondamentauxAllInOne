using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_Asynchrone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ce code est exécuté dans le thread principal dont l'id est {0}", Thread.CurrentThread.ManagedThreadId);

            Action actionAExecuter = () => { Console.WriteLine("Ce code est exécuté dans un thread séparé dont l'identifiant est {0}", Thread.CurrentThread.ManagedThreadId); };

            Task task = new Task(actionAExecuter);
            Task task2 = new Task(actionAExecuter);

            task.Start();
            task2.Start();

            Console.ReadLine();

            Traitement();
            Console.ReadLine();
            

        }

        private static void Traitement()
        {
            Task<long> tacheCalcul = new Task<long>(() =>
            {
                long result = 0;
                for (long i = 1; i <= 10000; i++)
                {
                    result += i;

                }
                return result;
            }
            );
            tacheCalcul.Start();
            Console.WriteLine(tacheCalcul.Result);
        }
    }
}
