using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    internal class Electronice
    {

        protected string brandul;
        protected int anul;




        public Electronice(string brandul)
        {
            this.brandul = brandul;
            Console.WriteLine("Constructorul din baza cu 1 parametri");

        }

        public Electronice(string brandul, int anul)
        {
            this.brandul = brandul;
            this.anul = anul;
            Console.WriteLine("Constructorul din baza cu 2 parametri");
        }

        public string descriereElectronice()
        {
            string t = "";

            t += "Brandul: " + brandul + "\n";
            t += "Anul: " + anul + "\n";

            return t;
        }

    }
}
