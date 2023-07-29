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
        protected string name;
        protected int age;
        protected string type;

        public Animal()
        {

        }

        public Animal(int id, string name, int age, string type)
        {
            this.type = type;
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Animal(string text)
        {
            string[] prop = text.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.name = prop[2];
            this.age = int.Parse(prop[3]);

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

        public int Age
        {
            get { return age; }
            set { age = value; }
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
            t += "Age: " + age + "\n";
            t += "Type: " + type + "\n";

            return t;
        }

    }
}
