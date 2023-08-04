using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire3
{
    public class User : Persoane
    {

        private DateTime dataNasteri;
        private bool genul;
        private int varsta;
        

        public User(int varsta, int id, string name,string password):base(id,name,password) { 
        
            this.varsta = varsta;
        
        }

        public User(bool genul,int varsta, int id) : base(id)
        {
            this.genul = genul;
            this.varsta = varsta;
        }

        public User(DateTime dataNasteri, bool genul, int varsta, int id,string name,string password):base(id,name,password)
        {
            this.dataNasteri = dataNasteri;
            this.genul = genul;
            this.varsta = varsta;
        }

        public bool Genul
        {
            get { return genul; }
            set { this.genul = value; }
        }

        public int Vasrta
        {
            get { return varsta; }
            set { varsta =  value; }
        }

        public DateTime DataNasteri
        {
            get { return dataNasteri; }
            set { dataNasteri =  value; }
        }

        public string descriereUser()
        {

            string t = base.descriere();

            t += "Datanasteri: " + dataNasteri.ToString() + "\n";
            t += "Genul: " + genul.ToString() + "\n";
            t += "Vasrta: " + varsta.ToString() + "\n";

            return t;
        }

    }
}
