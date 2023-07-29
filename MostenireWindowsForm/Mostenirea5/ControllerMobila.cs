﻿using System;
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

    }
}