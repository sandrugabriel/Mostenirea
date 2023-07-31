using MostenireWindowsForm.Mostenirea5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Panels
{
    internal class PnlToateCardurile:Panel
    {

        Form1 form;
        List<Mobila> listMobila;
        ControllerMobila controllerMobila;

        public PnlToateCardurile(Form1 form1)
        {

            this.form = form1;
            this.controllerMobila = new ControllerMobila();

            this.form.MinimumSize = new System.Drawing.Size(1458,717);
            this.form.MaximumSize = new System.Drawing.Size(2500,900);

            //PnlToateCarudirle
            this.Name = "PnlToateCardurile";
            this.Size = new System.Drawing.Size(1555, 840);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.Location = new System.Drawing.Point(0, 140);

            listMobila = controllerMobila.getAll();

            createCard(4);

        }

        public void createCard(int nr)
        {
            this.Controls.Clear();

            int x, y;

            x = 12;
            y = 13;

            int ct = 0;

            foreach (Mobila mobila in listMobila)
            {
                //MessageBox.Show(mobila.Type);
                ct++;
                if (mobila is Pat)
                {
                  //  MessageBox.Show(mobila.Type);
                    Pat pat = mobila as Pat;
                    PnlCardPat pnlCardPat = new PnlCardPat(form, pat);
                    pnlCardPat.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(pnlCardPat);
                }
                else if (mobila is Birou)
                {
                    Birou birou = mobila as Birou;
                    PnlCardBirou pnlCardBirou = new PnlCardBirou(form, birou);
                    pnlCardBirou.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(pnlCardBirou);
                }
                else if (mobila is Comoda)
                {
                    Comoda comoda = mobila as Comoda;
                    PnlCardComoda pnlCardComoda = new PnlCardComoda(form, comoda);
                    pnlCardComoda.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(pnlCardComoda);
                }
                else if (mobila is Dulap)
                {
                    Dulap dulap = mobila as Dulap;
                    PnlCardDulap pnlCardDulap = new PnlCardDulap(form, dulap);
                    pnlCardDulap.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(pnlCardDulap);
                }

                x +=325;

                if (ct % nr == 0)
                {
                    x = 12;
                    y +=325;
                }

                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }



    }
}
