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

        public Caine(DateTime dataNasteri, bool rasa, int id, string name, int age, string type): base(id, name, age, type)
        {

            this.dataNasteri = dataNasteri;
            this.rasa = rasa;

        }

        public Caine(string text) : base(text)
        {

            string[] prop = text.Split(',');
            this.dataNasteri = DateTime.Parse(prop[4]);
            this.rasa = bool.Parse(prop[5]);

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



    }
}
