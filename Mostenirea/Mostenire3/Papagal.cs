using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Papagal : Animal
    {

        private int pui;
        private bool vorbeste;

        public Papagal(int pui, bool vb, int id, string name, int age, string type) : base(id, name, age, type)
        {
            this.pui = pui;
            this.vorbeste = vb;
        }

        public Papagal(string text) : base(text)
        {
            string[] prop = text.Split(',');

            this.pui = int.Parse(prop[4]);
            this.vorbeste = bool.Parse(prop[5]);

        }

        public int Pui
        {
            get { return this.pui; }
            set { this.pui = value; }
        }

        public bool Vorbeste
        {
            get { return this.vorbeste; }
            set { this.vorbeste = value; }
        }

        public string descrierePapagal()
        {
            string t = base.descriereAnimal();
            t += "Are " + pui.ToString() + " pui" + "\n";
            t += "Vorbeste? : " + vorbeste.ToString() + "\n";

            return t;
        }

    }
}
