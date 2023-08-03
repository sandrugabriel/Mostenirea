using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Vehicle
    {
        protected string type;
        protected string brand;
        protected int year;
        protected int id;

        public Vehicle(int id,string brand, int year, string type)
        {
            this.brand = brand;
            this.year = year;
            this.type = type;
        }

        public Vehicle(string text)
        {
            string[] prop = text.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.brand = prop[2];
            this.year = int.Parse(prop[3]);

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string descriereVehicle()
        {
            string t = "";

            t += "Brand: " + brand + "\n";
            t += "Year: " + year + "\n";

            return t;
        }

        public string toSaveVehicle()
        {
            return type + "," + id.ToString() + "," + brand + "," + year + ",";
        }

    }
}
