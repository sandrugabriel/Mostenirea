using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    internal class SmartWatch:Electronice
    {

        private double inch;
        private bool rezistentApa;

        public SmartWatch() : base("watch1")
        {
            Console.WriteLine("Constructor cu 0 parametri");
        }

        public SmartWatch(double inch) : base("watch1")
        {
            this.inch = inch;
            Console.WriteLine("Constructor cu 1 parametri");
        }

        public SmartWatch(double inch, bool rezistentApa) : base("watch1")
        {
            this.inch = inch;
            this.rezistentApa = rezistentApa;
            Console.WriteLine("Constructor cu 2 parametri");
        }

        public string descriereWatch()
        {
            string text = base.descriereElectronice();

            text += "Inch: " + inch + "\n";
            text += "Rezistenta apa: " + rezistentApa + "\n";

            return text;
        }
    }
}
