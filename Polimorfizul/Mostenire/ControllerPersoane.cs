using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizul.Mostenire
{
    public class ControllerPersoane
    {

        private List<Persoana> persoane;

        public ControllerPersoane() {
        
            persoane = new List<Persoana>();

            load();
        }

        public void load()
        {

            string path = Directory.GetCurrentDirectory() + "/data/persoane.txt";
            //Console.WriteLine(path);
            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {
                string type = text.Split(',')[0];

                if (type.Equals("admin"))
                {
                    Admin admin = new Admin(text);
                    persoane.Add(admin);
                }
                else if (type.Equals("client"))
                {
                    Client client = new Client(text);
                    persoane.Add(client);
                }

            }

            streamReader.Close();
        }

        public void afisare()
        {
            for(int i=0;i<persoane.Count;i++)
            {

                Console.WriteLine(persoane[i].descriere());
            }
        }

    }
}
