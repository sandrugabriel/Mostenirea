using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Barca : Vehicle
    {

        private int nrLocuri;

        public Barca(int id, int nr, string brand, int year, string type):base(id,brand,year,type)
        {
            nrLocuri = nr;
        }

        public Barca(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.nrLocuri = int.Parse(prop[4]);

        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public string descriereBarca()
        {
            string t = base.descriereVehicle();

            t += "Nr de locuri: " + nrLocuri.ToString() + "\n";

            return t;
        }

        public string tosave()
        {
            string t = base.toSaveVehicle();
            t += nrLocuri.ToString();
            return t;
        }

    }
}
