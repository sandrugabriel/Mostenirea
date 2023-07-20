using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    internal class SoundBar:Electronice
    {

        private int nrCanale;
        private int putereW;

        public SoundBar() : base("soundbar1",2020)
        {
            Console.WriteLine("Constructor cu 0 parametri");
        }

        public SoundBar(int putereW) : base("soundbar1")
        {
            this.putereW = putereW;
            Console.WriteLine("Constructor cu 1 parametri");
        }

        public SoundBar(int nrCanale, int putereW) : base("soundbar1",2021)
        {
            this.nrCanale = nrCanale;
            this.putereW = putereW;
            Console.WriteLine("Constructor cu 2 parametri");

        }

        public string descriereSoundBar()
        {
            string text = base.descriereElectronice();

            text += "Nr canale: " + nrCanale + "\n";
            text += "Putere: " + putereW + "\n";

            return text;
        }
    }
}
