using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class Televizor:Electronice
    {

        private bool smart;

        public Televizor(bool smart, int id, string type) : base(type,id)
        {
            this.smart = smart;
        }

        public Televizor(string text) : base(text)
        {

            string[] prop = text.Split(',');

            this.smart = bool.Parse(prop[2]);

        }

        public bool Smart { get => smart; set => smart = value; }

        public string descriereTv()
        {
            string text = base.descriereElectronice();

            text += "Smart: " + smart + "\n";

            return text;
        }

        public string tosave()
        {
            string t =base.toSaveElectronice();
            t += smart.ToString();
            return t;
        }

    }
}
