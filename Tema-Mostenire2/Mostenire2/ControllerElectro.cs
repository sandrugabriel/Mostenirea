using Mostenirea.Mostenire2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_Mostenire1.Mostenire1
{
    internal class ControllerElectro
    {

        private List<Electronice> electro;

        public ControllerElectro()
        {

            electro = new List<Electronice>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/electro.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {

                switch (t.Split(',')[0])
                {

                    case "mobil":
                        electro.Add(new Mobil(t));
                        break;
                    case "watch":
                        electro.Add(new SmartWatch(t));
                        break;
                    case "soundbar":
                        electro.Add(new SoundBar(t));
                        break;
                    case "televizor":
                        electro.Add(new Televizor(t));
                        break;

                }

            }

            streamReader.Close();

        }

        public List<Electronice> getAll()
        {
            return electro;
        }

        public Electronice getElectroById(int id)
        {

            for (int i = 0; i < electro.Count; i++)
            {
                if (electro[i].Id == id)
                {
                    return electro[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getElectroById(id) != null)
            {

                id = random.Next(36, 1000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/electro.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < electro.Count; i++)
            {

                if (electro[i] is Mobil)
                {
                    Mobil av = electro[i] as Mobil;
                    t += av.tosave() + "\n";
                }
                else if (electro[i] is SmartWatch)
                {
                    SmartWatch car = electro[i] as SmartWatch;
                    t += car.tosave() + "\n";
                }
                else if (electro[i] is SoundBar)
                {
                    SoundBar c = electro[i] as SoundBar;
                    t += c.tosave() + "\n";
                }
                else if (electro[i] is Televizor)
                {
                    Televizor bir = electro[i] as Televizor;
                    t += bir.tosave() + "\n";
                }
            }


            return t;
        }

        public int pozId(int id)
        {

            for (int i = 0; i < electro.Count; i++)
            {
                if (electro[i].Id == id)
                    return i;
            }

            return -1;
        }

        public void stergere(int id)
        {

            int p = pozId(id);

            electro.RemoveAt(p);


        }

        public void delete(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/electro.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }


    }
}
