using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Barca : Vehicle
    {

        private int nrLocuri;

        public Barca()
        {
            Console.WriteLine("Eu sunt un constructor fara parametri");
        }

        public Barca(int nr)
        {
            nrLocuri = nr;
            Console.WriteLine($"Eu sunt un constructor cu un parametru \nNumarul de locuri:{nrLocuri}");

        }




    }
}
