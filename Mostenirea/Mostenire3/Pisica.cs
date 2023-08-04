using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Pisica :Animal
    {

        protected bool vede;
        protected int greutatea;

        public Pisica(bool vede, int gr, int id, string name, int age, string type):base(id,name,age,type) { 
        
            this.vede = vede;
            this.greutatea = gr;
        
        }

        public Pisica(string text):base(text) {

            string[] prop = text.Split(',');

            this.vede = bool.Parse(prop[4]);
            this.greutatea = int.Parse(prop[5]);
        
        }

        public int Greutatea
        {
            get { return this.greutatea; }
            set { this.greutatea = value; }
        }

        public bool Vede
        {
            get { return this.vede; }
            set { this.vede = value; }
        }

        public string descrierePisica()
        {

            string t = base.descriereAnimal();

            t += "Greutatea: " + greutatea.ToString() + "\n";
            t += "Vede? : " + vede.ToString() + "\n";

            return t;
        }

    }
}
