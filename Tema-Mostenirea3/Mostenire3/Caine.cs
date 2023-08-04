using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Caine : Animal
    {

        private DateTime dataNasteri;
        private bool rasa;

        public Caine(DateTime dataNasteri, bool rasa, int id, string name, string type): base(id, name,type)
        {

            this.dataNasteri = dataNasteri;
            this.rasa = rasa;

        }

        public Caine(string text) : base(text)
        {

            string[] prop = text.Split(',');
            this.dataNasteri = DateTime.Parse(prop[3]);
            this.rasa = bool.Parse(prop[4]);

        }

        public DateTime DataNasteri
        {
            get { return dataNasteri; }
            set { dataNasteri = value; }
        }

        public bool Rasa
        {
            get { return rasa; }
            set { rasa = value; }
        }

        public string descriereCaine()
        {
            string t = base.descriereAnimal();

            t += "Data nasteri: " + dataNasteri.ToString() + "\n";
            t += "Rasa: " + rasa.ToString() + "\n";
        
            return t;
        }

        public string tosave()
        {
            string t = base.toSave();
            t += dataNasteri.ToString() + "," + rasa.ToString();
            return t;
        }

    }
}
