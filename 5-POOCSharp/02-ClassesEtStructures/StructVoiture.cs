using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesEtStructures
{
    public struct StructVoiture
    {
        public string brand;
        public string model;
        public int kilometer;

        public StructVoiture(string brand, string model, int kilometer)
        {
            this.brand = brand;
            this.model = model;
            this.kilometer = kilometer;
        }
    }
}
