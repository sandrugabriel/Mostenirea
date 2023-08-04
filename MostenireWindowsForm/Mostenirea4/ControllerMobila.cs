using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Mostenirea5
{
    internal class ControllerMobila
    {

        private List<Mobila> listMobila;

        public ControllerMobila()
        {

            listMobila = new List<Mobila>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/mobila.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {

                switch (t.Split(',')[0])
                {

                    case "pat":
                        listMobila.Add(new Pat(t));
                        break;
                    case "birou":
                        listMobila.Add(new Birou(t));
                        break;
                    case "comoda":
                        listMobila.Add(new Comoda(t));
                        break;
                    case "dulap":
                        listMobila.Add(new Dulap(t));
                        break;

                }

            }

            streamReader.Close();

        }

        public void afisare()
        {

            for (int i = 0; i < listMobila.Count; i++)
            {

                if (listMobila[i] is Pat)
                {
                    Pat pat = listMobila[i] as Pat;
                    MessageBox.Show(pat.descrierePat());
                }
                else if (listMobila[i] is Birou)
                {
                    Birou birou = listMobila[i] as Birou;
                    MessageBox.Show(birou.descriereBirou());
                }
                else if (listMobila[i] is Comoda)
                {
                    Comoda comoda = listMobila[i] as Comoda;
                    MessageBox.Show(comoda.descriereComoda());
                }
                else if (listMobila[i] is Dulap)
                {
                    Dulap dulap = listMobila[i] as Dulap;
                    MessageBox.Show(dulap.descriereDulap());
                }

            }
        }

        public List<Mobila> getAll()
        {
            return listMobila;
        }
        public Mobila getMobilaById(int id)
        {

            for (int i = 0; i < listMobila.Count; i++)
            {
                if (listMobila[i].Id == id)
                {
                    return listMobila[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getMobilaById(id) != null)
            {

                id = random.Next(36, 1000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/mobila.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < listMobila.Count; i++)
            {

                if (listMobila[i] is Pat)
                {
                    Pat pat = listMobila[i] as Pat;
                    t += pat.toSave() + "\n";
                }
                else if (listMobila[i] is Dulap)
                {
                    Dulap dulap = listMobila[i] as Dulap;
                    t += dulap.toSave() + "\n";
                }
                else if (listMobila[i] is Comoda)
                {
                    Comoda com = listMobila[i] as Comoda;
                    t += com.toSave() + "\n";
                }
                else if (listMobila[i] is Birou)
                {
                    Birou bir = listMobila[i] as Birou;
                    t += bir.toSave() + "\n";
                }
            }


            return t;
        }

        public int pozId(int id)
        {

            for (int i = 0; i < listMobila.Count; i++)
            {
                if (listMobila[i].Id == id)
                    return i;
            }

            return -1;
        }

        public void stergere(int id)
        {

            int p = pozId(id);

            listMobila.RemoveAt(p);


        }

        public void delete(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/mobila.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }

    }
}
