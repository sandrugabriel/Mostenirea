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

        public Car(string brand, int year, int numOfDoors, string type) : base(brand, year,type)
        {
            this.numOfDoors = numOfDoors;
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }

        public Car(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.numOfDoors = int.Parse(prop[3]);
        }

        public int NumOfDoors
        {
            get { return this.numOfDoors;}
        }

        public string descriereCar()
        {
            string t = base.descriereVehicle();

            t += "Nr usi: " + numOfDoors.ToString() + "\n";
            return t;
        }

    }
}
