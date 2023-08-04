using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class SoundBar:Electronice
    {

        private int nrCanale;
        private int putereW;

        public int NrCanale { get => nrCanale; set => nrCanale = value; }
        public int PutereW { get => putereW; set => putereW = value; }

        public SoundBar(int nrCanale, int putereW,int id, string type) : base(type,id)
        {
            this.nrCanale = nrCanale;
            this.putereW = putereW;

        }

        public SoundBar(string text) : base(text)
        {
            string[] prop = text.Split(',');

            this.nrCanale = int.Parse(prop[2]);
            this.putereW = int.Parse(prop[3]);

        }


        public string descriereSoundBar()
        {
            string text = base.descriereElectronice();

            text += "Nr canale: " + nrCanale + "\n";
            text += "Putere: " + putereW + "\n";

            return text;
        }

        public string tosave()
        {
            string t=base.toSaveElectronice();
            t += nrCanale.ToString() + "," + putereW.ToString();
            return t;
        }

    }
}
