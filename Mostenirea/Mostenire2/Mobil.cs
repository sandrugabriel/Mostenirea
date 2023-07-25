using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class Mobil:Electronice
    {

        private double inch;
        private int gb;

        public Mobil():base("test",2019) {
            Console.WriteLine("Constructor cu 0 parametri");
        }

        public Mobil(int gb):base("test")
        {
            this.gb = gb;
            Console.WriteLine("Constructor cu 1 parametri");
        }

        public Mobil(double inch, int gb):base("test",2019)
        {
            this.inch = inch;
            this.gb = gb;
            Console.WriteLine("Constructor cu 2 parametri");
        }

        public string descriereMobil()
        {
            string text = base.descriereElectronice();

            text += "Inch: " + inch+"\n";
            text+="Gb: "+gb+"\n";

            return text;
        }

    }
}
