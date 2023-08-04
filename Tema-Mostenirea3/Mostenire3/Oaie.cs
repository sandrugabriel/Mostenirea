using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Oaie : Animal
    {

        private bool tunsa;

        public Oaie( bool tunsa, int id, string name,string type):base(id,name,type)
        {
            this.tunsa = tunsa;
        }

        public Oaie(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.tunsa = bool.Parse(prop[3]);

        }
            
        public bool Tunsa
        {
            get { return this.tunsa; }
            set { this.tunsa = value;}
        }

        public string tosave()
        {
            string t = base.toSave();
            t += tunsa.ToString();
            return t; 
        }

    }
}
