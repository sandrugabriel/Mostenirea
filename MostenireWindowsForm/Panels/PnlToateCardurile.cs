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
        Label lbl1;
        public PnlToateCardurile(Form1 form1)
        {

            this.form = form1;
            this.controllerMobila = new ControllerMobila();

            this.form.MinimumSize = new System.Drawing.Size(1458,717);
            this.form.MaximumSize = new System.Drawing.Size(2500,900);

            //PnlToateCarudirle
            this.Name = "PnlToateCardurile";
            this.Size = new System.Drawing.Size(1555, 750);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.Location = new System.Drawing.Point(0, 135);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");



            listMobila = controllerMobila.getAll();

            createCard(4);

        }

        public void createCard(int nr)
        {
            this.Controls.Clear();

            lbl1 = new Label();
            lbl1.Location = new System.Drawing.Point(250, 1050);

           // this.Controls.Add(lbl1);

            int x, y;

            x = 75;
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

                x +=350;

                if (ct % nr == 0)
                {
                    x = 75;
                    y +=340;
                }

                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }



    }
}
