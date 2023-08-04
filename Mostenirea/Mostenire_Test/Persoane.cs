using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire3
{
    public class Persoane
    {
        protected int id;
        protected string name;
        protected string password;

        public Persoane() {
        
        }

        public Persoane(int id)
        {
            this.id = id;
        }

        public Persoane(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string descriere()
        {
            string t = "";
            t += "ID: " + id + "\n";
            t += "Name: " + name + "\n";
            t += "Password: " + password + "\n";

            return t;
        }

    }
}
