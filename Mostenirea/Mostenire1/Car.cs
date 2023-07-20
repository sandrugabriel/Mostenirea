using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Car : Vehicle
    {

        private int numOfDoors;

        public Car(string brand, int year, int numOfDoors) : base(brand, year)
        {
            this.numOfDoors = numOfDoors;
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }

    }
}
