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

        public Mobil(double inch, int gb, int id, string type):base(type,id)
        {
            this.inch = inch;
            this.gb = gb;
        }

        public Mobil(string text):base(text)
        {

            string[] prop = text.Split(',');
            
            this.inch = double.Parse(prop[2]);
            this.gb = int.Parse(prop[3]);

        }

        public double Inch
        {
            get { return inch; }
            set { inch = value; }
        }

        public int Gb
        {
            get { return gb; }
            set { gb = value; }
        }

        public string descriereMobil()
        {
            string text = base.descriereElectronice();

            text += "Inch: " + inch+"\n";
            text+="Gb: "+gb+"\n";

            return text;
        }

        public string tosave()
        {
            string t = base.toSaveElectronice();

            t += inch.ToString() + "," + gb.ToString();
            return t;
        }

    }
}
