using Mostenirea.Mostenire4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_Mostenire1.Mostenire1
{
    internal class ControllerAnimale
    {

        private List<Animal> animale;

        public ControllerAnimale()
        {

            animale = new List<Animal>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/animale.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {

                switch (t.Split(',')[0])
                {

                    case "caine":
                        animale.Add(new Caine(t));
                        break;
                    case "pisica":
                        animale.Add(new Pisica(t));
                        break;
                    case "papagal":
                        animale.Add(new Papagal(t));
                        break;
                    case "oaie":
                        animale.Add(new Oaie(t));
                        break;

                }

            }

            streamReader.Close();

        }

        public List<Animal> getAll()
        {
            return animale;
        }

        public Animal getAnimalById(int id)
        {

            for (int i = 0; i < animale.Count; i++)
            {
                if (animale[i].Id == id)
                {
                    return animale[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getAnimalById(id) != null)
            {

                id = random.Next(36, 1000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/animale.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < animale.Count; i++)
            {

                if (animale[i] is Caine)
                {
                    Caine av = animale[i] as Caine;
                    t += av.tosave() + "\n";
                }
                else if (animale[i] is Pisica)
                {
                    Pisica car = animale[i] as Pisica;
                    t += car.tosave() + "\n";
                }
                else if (animale[i] is Papagal)
                {
                    Papagal c = animale[i] as Papagal;
                    t += c.tosave() + "\n";
                }
                else if (animale[i] is Oaie)
                {
                    Oaie bir = animale[i] as Oaie;
                    t += bir.tosave() + "\n";
                }
            }


            return t;
        }

        public int pozId(int id)
        {

            for (int i = 0; i < animale.Count; i++)
            {
                if (animale[i].Id == id)
                    return i;
            }

            return -1;
        }

        public void stergere(int id)
        {

            int p = pozId(id);

            animale.RemoveAt(p);


        }

        public void delete(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/animale.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }


    }
}
