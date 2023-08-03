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

        public Car(int id, int numOfDoors, string brand, int year, string type):base(id, brand,year,type)
        {
            this.numOfDoors = numOfDoors;
        }

        public Car(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.numOfDoors = int.Parse(prop[4]);
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

        public string tosave()
        {
            string t = base.toSaveVehicle();

            t += numOfDoors.ToString();
            return t;
        }

    }
}
