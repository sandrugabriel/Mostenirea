using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class SmartWatch:Electronice
    {

        private double inch;
        private bool rezistentApa;

        public SmartWatch(double inch, bool rezistentApa, string type, int id) : base(type,id)
        {
            this.inch = inch;
            this.rezistentApa = rezistentApa;
        }

        public SmartWatch(string text):base(text)
        {
            string[] prop = text.Split(',');

            this.inch = double.Parse(prop[2]);
            this.rezistentApa = bool.Parse(prop[3]);
        
        }

        public double Inch
        {
            get { return inch; }
            set { inch =  value; }    
        }

        public bool Rezistenta
        {
            get { return rezistentApa; }
            set { rezistentApa = value; }
        }

        public string descriereWatch()
        {
            string text = base.descriereElectronice();

            text += "Inch: " + inch + "\n";
            text += "Rezistenta apa: " + rezistentApa + "\n";

            return text;
        }

        public string tosave()
        {
            string t = base.toSaveElectronice();
            t += inch.ToString() + "," + rezistentApa.ToString();
            return t;
        }

    }
}
