using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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

        public Avion(int nrLocuri, int nrPiloti, string brand, int year, string type):base(brand,year,type)
        {
            this.nrLocuri = nrLocuri;
            this.nrPiloti = nrPiloti;
            //Console.WriteLine($"Eu sunt un constructor cu 2 parametri");
        }

        public Avion(string text):base(text) {


            string[] prop = text.Split(',');

            this.nrLocuri = int.Parse(prop[3]);
            this.nrPiloti = int.Parse(prop[4]);
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public int Ntpiloti
        {
            get { return nrPiloti; }
            set { nrPiloti = value; }
        }

        public string descriereAvion()
        {
            string t = base.descriereVehicle();

            t += "Nr locuri: " + nrLocuri.ToString() + "\n";
            t += "Nr piloti: " + nrPiloti.ToString() + "\n";

            return t;
        }

    }
}
