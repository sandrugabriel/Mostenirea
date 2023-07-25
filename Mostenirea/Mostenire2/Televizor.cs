using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class Televizor:Electronice
    {

        private int dimensiuneCm;
        private bool smart;

        public Televizor() : base("tv1")
        {
            Console.WriteLine("Constructor cu 0 parametri");
        }

        public Televizor(bool smart) : base("tv1",2019)
        {
            this.smart = smart;
            Console.WriteLine("Constructor cu 1 parametri");
        }

        public Televizor(int dimensiuneCm, bool smart) : base("tv1",2019)
        {
            this.dimensiuneCm = dimensiuneCm;
            this.smart = smart;
            Console.WriteLine("Constructor cu 2 parametri");
        }

        public string descriereTv()
        {
            string text = base.descriereElectronice();

            text += "Cm: " + dimensiuneCm + "\n";
            text += "Smart: " + smart + "\n";

            return text;
        }
    }
}
