using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Birou : Mobila
    {

        private double inaltime;
        private double lungime;
        private double lagime;

        public Birou(string type, int id, int pret, double inaltime, double lungime, double lagime) : base(type, id, pret)
        {

            this.inaltime = inaltime;
            this.lungime = lungime;
            this.lagime = lagime;

        }

        public Birou(string text):base(text) {

            string[] prop = text.Split(',');

            this.inaltime = double.Parse(prop[3]);
            this.lungime = double.Parse(prop[4]);
            this.lagime = double.Parse(prop[5]);

        }

        public double Inaltime
        {
            get { return this.inaltime; }
            set { this.inaltime = value; }
        }

        public double Lungime
        {
            get { return this.lungime; }
            set { this.lungime = value;}
        }

        public double Lagime
        {
            get { return this.lagime; }
            set { this.lagime = value; }
        }

        public string descriereBirou()
        {
            string t = base.descriere();

            t += "Inaltime: " + inaltime + "\n";
            t += "Lungime: " + lungime + "\n";
            t += "Lagime: " + lagime + "\n";

            return t;
        }

        public string toSave()
        {
            string t = base.toSaveMobila();
            t += inaltime.ToString() + "," + lungime.ToString() + "," + lagime.ToString();
            return t;
        }
    }
}
