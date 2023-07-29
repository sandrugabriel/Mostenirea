using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Dulap : Mobila
    {

        private bool oglinda;
        private double inaltime;
        private double lungime;

        public Dulap(string type, int id,int pret, bool oglinda, double inaltime, double lungime):base(type,id, pret)
        {
            this.oglinda = oglinda;
            this.inaltime = inaltime;
            this.lungime = lungime;
        }

        public Dulap(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.oglinda = bool.Parse(prop[3]);
            this.inaltime = double.Parse(prop[4]);
            this.lungime = double.Parse(prop[5]);

        }

        public bool Oglinda
        {
            get { return this.oglinda;}
            set { this.oglinda = value;}
        }

        public double Inaltime
        {
            get { return this.inaltime;}
            set { this.inaltime = value;}
        }

        public double Lungime
        {
            get { return this.lungime;}
            set { this.lungime = value;}
        }

        public string descriereDulap()
        {

            string t = base.descriere();

            t += "Oglinda? :" + oglinda + "\n";
            t += "Inalgime: " + inaltime + "\n";
            t += "Lungime: " + lungime + "\n";

            return t;
        }

    }
}
