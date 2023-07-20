using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Avion : Vehicle
    {

        private int nrLocuri;
        private int nrPiloti;

        public Avion()
        {
            Console.WriteLine("Eu sunt un constructor fara parametri");
        }

        public Avion(int nrLocuri, int nrPiloti)
        {
            this.nrLocuri = nrLocuri;
            this.nrPiloti = nrPiloti;
            Console.WriteLine($"Eu sunt un constructor cu 2 parametri");
        }


    }
}
