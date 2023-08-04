using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class Mobila
    {

        private string type;
        private int id;
        private int pret;

        public Mobila(string type, int id, int pret)
        {
            this.type = type;
            this.id = id;
            this.pret = pret;
        }

        public Mobila(string text) {

            string[] prop = text.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.pret = int.Parse(prop[2]);
        
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public string descriere()
        {

            string t = "";

            t += "Id: " + id + "\n";
            t += "Pret: " + pret + "\n";
            t += "Type: " + type + "\n";

            return t;
        }

        public string toSaveMobila()
        {
            return type + "," + id.ToString() + "," + pret.ToString() + ",";
        }

    }
}
