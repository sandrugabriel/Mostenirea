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

        public Vehicle()
        {
            Console.WriteLine("Eu sunt un constructor din baza cu 0 parametri");
        }

        public Vehicle(int year)
        {
            this.year = year;
            Console.WriteLine($"Eu sunt un constructor din baza cu 1 parametri \nAnul: {year}");
        }

        public Vehicle(string brand, int year, string type)
        {
            this.brand = brand;
            this.year = year;
          //  Console.WriteLine($"Eu sunt un constructor din baza cu 2 parametri \nBrand-ul: {year} /nAnul: {year}");
            this.type = type;
        }

        public Vehicle(string text)
        {
            string[] prop = text.Split(',');

            this.type = prop[0];
            this.brand = prop[1];
            this.year = int.Parse(prop[2]);

        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}\nYear: {year}");
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
    }
}
