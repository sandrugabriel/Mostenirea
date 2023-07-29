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

        private string rasa;
        private bool tunsa;

        public Oaie(string rasa, bool tunsa, int id, string name, int age, string type):base(id,name,age,type)
        {
            this.rasa = rasa;
            this.tunsa = tunsa;
        }

        public Oaie(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.rasa = prop[4];
            this.tunsa = bool.Parse(prop[5]);

        }
            
        public string Raza
        {
            get { return this.rasa; }
            set { this.rasa = value; }
        }

        public bool Tunsa
        {
            get { return this.tunsa; }
            set { this.tunsa = value;}
        }

        public string descriereOaie()
        {
            string t = base.descriereAnimal();
            t += "Raza" + rasa + "\n";
            t += "Tunsa? : " + tunsa.ToString() + "\n";
            return t;
        }

    }
}
