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

        public Barca(int nr, string brand, int year, string type):base(brand,year,type)
        {
            nrLocuri = nr;
         //   Console.WriteLine($"Eu sunt un constructor cu un parametru \nNumarul de locuri:{nrLocuri}");

        }

        public Barca(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.nrLocuri = int.Parse(prop[3]);

        }

        public string descriereBarca()
        {
            string t = base.descriereVehicle();

            t += "Nr de locuri: " + nrLocuri.ToString() + "\n";

            return t;
        }

    }
}
