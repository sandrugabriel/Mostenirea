using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizul.Mostenire
{
    public class Persoana
    {
        protected string type;
        protected int id;
        protected string name;

        public Persoana(string type,int id, string name)
        {
            this.type = type;
            this.id = id;
            this.name = name;
        }

        public Persoana(string text)
        {
            string[] prop = text.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.name = prop[2];
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public virtual string descriere()
        {
            string t = "";
            t += "Type: " + type + "\n";
            t += "Id: " + id.ToString() + "\n";
            t += "Name: " + name + "\n";
            return t;
        }

    }
}
