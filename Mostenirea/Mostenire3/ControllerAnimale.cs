using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenirea.Mostenire4
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
            string path = Directory.GetCurrentDirectory() + "/data/animale.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
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

        public void afisare()
        {

            for(int i = 0; i < animale.Count; i++)
            {
                if (animale[i] is Caine)
                {
                    Caine caine = animale[i] as Caine;
                    Console.WriteLine(caine.descriereCaine());
                }
                else if (animale[i] is Pisica)
                {
                    Pisica pisica = animale[i] as Pisica;
                    Console.WriteLine(pisica.descrierePisica());
                }
                else if (animale[i] is Oaie)
                {
                    Oaie oaie = animale[i] as Oaie;
                    Console.WriteLine(oaie.descriereOaie());
                }
                else if (animale[i] is Papagal)
                {
                    Papagal papagal = animale[i] as Papagal;
                    Console.WriteLine(papagal.descrierePapagal());
                }
            }

        }

    }
}
