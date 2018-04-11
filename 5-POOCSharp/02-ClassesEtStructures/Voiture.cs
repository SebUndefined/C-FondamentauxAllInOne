using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesEtStructures
{
    class Voiture
    {
        public string brand;
        public string model;
        public int kilometer;
        private bool isStarted;

        public Voiture()
        {
        }
        //Constructeur ayant une seul instruction
        public Voiture(string brand) => this.brand = brand;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="brand">The car brand</param>
        /// <param name="model">The car model</param>
        /// <param name="kilometer">the car kilometers</param>
        public Voiture(string brand, string model, int kilometer)
        {
            this.brand = brand;
            this.model = model;
            this.kilometer = kilometer;
        }

        public void Demarrer()
        {
            this.isStarted = true;
            Console.WriteLine("Vroum");
        }

        public bool IsStarted() => isStarted;

    }
}
