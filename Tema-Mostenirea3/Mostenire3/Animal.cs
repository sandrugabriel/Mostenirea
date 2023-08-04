using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
{
    internal class Animal
    {

        protected int id;
        protected string type;
        protected string name;

        public Animal(int id, string name, string type)
        {
            this.type = type;
            this.id = id;
            this.name = name;
        }

        public Animal(string text)
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
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string descriereAnimal()
        {
            string t = "";
            t += "Id: " + id.ToString() + "\n";
            t += "Name: " + name + "\n";
            t += "Type: " + type + "\n";

            return t;
        }

        public string toSave()
        {
            return type + "," + id.ToString() + "," + name + ",";
        }

    }
}
