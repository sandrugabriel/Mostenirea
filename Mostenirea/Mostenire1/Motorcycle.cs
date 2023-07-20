using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Motorcycle : Vehicle
    {

        private bool hasSidecar;

        public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
        {
            this.hasSidecar = hasSidecar;
        }

        public void Ride()
        {
            Console.WriteLine("The motorcycle is riding.");
        }

    }
}
