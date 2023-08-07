using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizul.Mostenire
{
    public class Client : Persoana
    {

        private string password;
        private bool gen;

        public Client(string password, bool gen, int id, string name,string type):base(type, id,name)
        {
            this.password = password;
            this.gen = gen;
        }

        public Client(string text) : base(text)
        {
            string[] prop = text.Split(',');

            this.password = prop[3];
            this.gen = bool.Parse(prop[4]);
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Gen
        {
            get { return gen; }
            set { gen = value; }
        }

        public string descriereClient()
        {
            string t = base.descriere();
            t += "Password: " + password + "\n";
            t += "Barbat : " + gen + "\n";
            return t;
        }
        public override string descriere()
        {
            string t = base.descriere();
            t += "Password: " + password + "\n";
            t += "Barbat : " + gen + "\n";
            return t;
        }

    }
}
