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

        public Avion(int id,int nrLocuri, int nrPiloti, string brand, int year, string type):base(id,brand,year,type)
        {
            this.nrLocuri = nrLocuri;
            this.nrPiloti = nrPiloti;
        }

        public Avion(string text):base(text) {


            string[] prop = text.Split(',');

            this.nrLocuri = int.Parse(prop[4]);
            this.nrPiloti = int.Parse(prop[5]);
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public int Nrpiloti
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

        public string tosave()
        {
            string t = base.toSaveVehicle();
            t += nrLocuri.ToString() + "," + nrPiloti.ToString();
            return t;
        }

    }
}
