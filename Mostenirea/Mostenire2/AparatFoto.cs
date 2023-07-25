using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class AparatFoto:Electronice
    {

        private int dimensuneDisplay;
        private int greutate;

        public AparatFoto():base("aparata1")
        {
            Console.WriteLine("Constructor cu 0 parametri");
        }

        public AparatFoto(int greutate) : base("aparata1")
        {
            this.greutate = greutate;
            Console.WriteLine("Constructor cu 1 parametri");

        }

        public AparatFoto(int dimensuneDisplay, int greutate) : base("aparata1",2019)
        {
            this.dimensuneDisplay = dimensuneDisplay;
            this.greutate = greutate;
            Console.WriteLine("Constructor cu 2 parametri");

        }

        public string descriereAparat()
        {
            string text = base.descriereElectronice();

            text += "Dim display: " + dimensuneDisplay + "\n";
            text += "Greutate: " + greutate + "\n";

            return text;
        }
    }
}
