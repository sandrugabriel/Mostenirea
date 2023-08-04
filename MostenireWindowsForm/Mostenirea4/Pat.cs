using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Pat : Mobila
    {

        private double lungime;
        private double latime;

        public Pat(string type, int id, double lungime, double latime, int pret):base(type,id,pret)
        {
            this.lungime = lungime;
            this.latime = latime;
        }

        public Pat(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.lungime = double.Parse(prop[3]);
            this.latime = double.Parse(prop[4]);

        }

        public double Lungime
        {
            get { return lungime; }
            set { lungime = value; }
        }

        public double Latime
        {
            get { return latime; }
            set { latime = value; }
        }

        public string descrierePat()
        {
            string t = base.descriere();

            t += "Lungimea: " + lungime + "\n";
            t += "Latime: " + latime + "\n";

            return t;
        }

        public string toSave()
        {
            string t = base.toSaveMobila();
            t += lungime.ToString() + "," + latime.ToString();
            return t;
        }

    }
}
