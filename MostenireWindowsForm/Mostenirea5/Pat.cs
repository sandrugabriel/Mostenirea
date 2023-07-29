using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Pat : Mobila
    {

        private int lungime;
        private int latime;

        public Pat(string type, int id, int lungime, int latime, int pret):base(type,id,pret)
        {
            this.lungime = lungime;
            this.latime = latime;
        }

        public Pat(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.lungime = int.Parse(prop[3]);
            this.latime = int.Parse(prop[4]);

        }

        public int Lungime
        {
            get { return lungime; }
            set { lungime = value; }
        }

        public int Latime
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

    }
}
