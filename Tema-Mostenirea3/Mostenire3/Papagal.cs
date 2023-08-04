using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Papagal : Animal
    {

        private int greutatea;
        private string rasa;

        public string Rasa { get => rasa; set => rasa = value; }
        public int Greutatea { get => greutatea; set => greutatea = value; }

        public Papagal(int gru, string rasa, int id, string name, string type) : base(id, name, type)
        {
            this.rasa = rasa;
            this.greutatea = gru;
        }

        public Papagal(string text) : base(text)
        {
            string[] prop = text.Split(',');

            this.greutatea = int.Parse(prop[3]);
            this.rasa = prop[4];

        }

        public string tosave()
        {
            string t = base.toSave();
            t += greutatea.ToString() + "," + rasa.ToString();
            return t;
        }

    }
}
