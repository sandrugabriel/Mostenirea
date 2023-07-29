using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Comoda : Mobila
    {

        private string culoare;
        private int inaltime;
        private int lungime;

        public Comoda(string type, int id,int pret, string culoare, int inaltime, int lungime):base(type,id, pret)
        {
            this.culoare = culoare;
            this.inaltime = inaltime;
            this.lungime = lungime;
        }

        public Comoda(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.culoare = prop[3];
            this.inaltime = int.Parse(prop[4]);
            this.lungime = int.Parse(prop[5]);

        }

        public string Culoare
        {
            get { return this.culoare;}
            set { this.culoare = value;}
        }

        public int Inaltime
        {
            get { return this.inaltime;}
            set { this.inaltime = value;}
        }

        public int Lungime
        {
            get { return this.lungime;}
            set { this.lungime = value;}
        }

        public string descriereComoda()
        {

            string t = base.descriere();

            t += "Culoare: " + culoare + "\n";
            t += "Inaltime: " + inaltime + "\n";
            t += "Lungime: " + lungime + "\n";

            return t;
        }

    }
}
