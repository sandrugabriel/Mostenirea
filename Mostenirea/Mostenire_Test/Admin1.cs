using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire3
{
    public class Admin1 : Persoane
    {

        private bool accesFull;
        private DateTime dataIntrari;
        private bool genul;

        public Admin1(bool accesFull, int id, string name, string password):base(id,name,password) {
        
            this.accesFull = accesFull;
        
        }

        public Admin1(bool accesFull, DateTime data, int id, string name, string password) : base(id,name,password)
        {
            this.accesFull = accesFull;
            this.dataIntrari = data;
        }

        public Admin1(bool acces,DateTime data,bool genul, int id, string name, string password):base(id,name,password)
        {
            this.accesFull = acces;
            this.dataIntrari = data;
            this.genul = genul;

        }

        public bool AccesFull
        {
            get { return accesFull; }
            set { accesFull = value; }
        }

        public DateTime DataIntrari
        {
            get { return dataIntrari; }
            set { dataIntrari = value; }
        }

        public bool Genul
        {
            get { return genul; }
            set { genul = value; }
        }

        public string descriereAdmin()
        {
            string t = base.descriere();

            t += "Accesfull: " + accesFull.ToString() + "\n";
            t += "Data intrari: " + dataIntrari.ToString() + "\n";
            t += "Genul: " + genul + "\n";

            return t;
        }

    }
}
