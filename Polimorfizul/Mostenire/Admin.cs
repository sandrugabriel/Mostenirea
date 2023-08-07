using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizul.Mostenire
{
    public class Admin : Persoana
    {

        private bool acces;
        private string password;

        public Admin(bool acces, string password, int id, string name, string type):base(type,id, name)
        {
            this.acces = acces;
            this.password = password;
        }

        public Admin(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.acces = bool.Parse(prop[3]);
            this.password = prop[4];
            
        }

        public bool Acces
        {
            get { return acces; }
            set { acces = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

       public string descriereAdmin()
        {
            string t = base.descriere();
            t += "Acces: " + acces + "\n";
            t += "Password: " + password + "\n";
            return t;
        }

        public override string descriere()
        {
            string t = base.descriere();
            t += "Acces: " + acces + "\n";
            t += "Password: " + password + "\n";
            return t;
        }
    }
}
