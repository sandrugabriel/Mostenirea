using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire1
{
    internal class Motorcycle : Vehicle
    {

        private bool hasSidecar;

        public Motorcycle(int id,string type, string brand, int year , bool hasSidecar) : base(id,brand,year,type)
        {
            this.hasSidecar = hasSidecar;
        }

        public Motorcycle(string text):base(text)
        {

            string[] prop = text.Split(',');

            this.hasSidecar = bool.Parse(prop[4]);

        }

        public bool HasSidecar
        {
            get { return hasSidecar; }
            set { this.hasSidecar = value;}
        }

        public string tosave()
        {
            string t = base.toSaveVehicle();
            t += hasSidecar.ToString();
            return t;
        }

    }
}
