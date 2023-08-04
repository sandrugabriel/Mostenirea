using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire2
{
    public class Electronice
    {

        protected string type;
        protected int id;

        public Electronice(string type, int id)
        {
            this.type = type;
            this.id = id;
        }

        public Electronice(string text) {

            string[] prop = text.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string descriereElectronice()
        {
            string t = "";

            t += "Type: " + type + "\n";
            t += "Id: " + id + "\n";

            return t;
        }

        public string toSaveElectronice()
        {
            return type + "," + id + ",";
        }

    }
}
