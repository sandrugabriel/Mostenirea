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

        private int inaltime;
        private int lungime;
        private int lagime;

        public Birou(string type, int id, int pret, int inaltime, int lungime, int lagime) : base(type, id, pret)
        {

            this.inaltime = inaltime;
            this.lungime = lungime;
            this.lagime = lagime;

        }

        public Birou(string text):base(text) {

            string[] prop = text.Split(',');

            this.inaltime = int.Parse(prop[3]);
            this.lungime = int.Parse(prop[4]);
            this.lagime = int.Parse(prop[5]);

        }

        public int Inaltime
        {
            get { return this.inaltime; }
            set { this.inaltime = value; }
        }

        public int Lungime
        {
            get { return this.lungime; }
            set { this.lungime = value;}
        }

        public int Lagime
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

    }
}
