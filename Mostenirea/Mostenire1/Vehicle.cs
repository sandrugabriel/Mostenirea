using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Vehicle
    {
        protected string brand;
        protected int year;

        public Vehicle()
        {
            Console.WriteLine("Eu sunt un constructor din baza cu 0 parametri");
        }

        public Vehicle(string brand)
        {
            this.brand = brand;
            Console.WriteLine($"Eu sunt un constructor din baza cu 1 parametri \nBrand-ul: {brand}");
        }

        public Vehicle(int year)
        {
            this.year = year;
            Console.WriteLine($"Eu sunt un constructor din baza cu 1 parametri \nAnul: {year}");
        }

        public Vehicle(string brand, int year)
        {
            this.brand = brand;
            this.year = year;
            Console.WriteLine($"Eu sunt un constructor din baza cu 2 parametri \nBrand-ul: {year} /nAnul: {year}");
        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}\nYear: {year}");
        }

    }
}
