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

        public Motorcycle(int year, bool hasSidecar) : base(year)
        {
            this.hasSidecar = hasSidecar;
        }

        public void Ride()
        {
            Console.WriteLine("The motorcycle is riding.");
        }

    }
}
