using Mostenirea.Mostenire4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema_Mostenire1.Mostenire1;
using Tema_Mostenirea3;

namespace MostenireWindowsForm.Panels
{
    internal class PnlToateCardurile:Panel
    {

        Form1 form;
        List<Animal> animale;
        ControllerAnimale controllerAnimale;
        Label lbl1;
        public PnlToateCardurile(Form1 form1)
        {

            this.form = form1;
            this.controllerAnimale = new ControllerAnimale();

            this.form.MinimumSize = new System.Drawing.Size(1458,717);
            this.form.MaximumSize = new System.Drawing.Size(2500,900);

            //PnlToateCarudirle
            this.Name = "PnlToateCardurile";
            this.Size = new System.Drawing.Size(1555, 750);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.Location = new System.Drawing.Point(0, 135);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");



            animale = controllerAnimale.getAll();

            createCard(4);
            this.BringToFront();
        }

        public void createCard(int nr)
        {
            this.Controls.Clear();

            lbl1 = new Label();
            lbl1.Location = new System.Drawing.Point(250, 1050);

            int x, y;

            x = 75;
            y = 13;

            int ct = 0;

            foreach (Animal animal in animale)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(form, animal);
                pnlCard.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(pnlCard);

                x += 350;

                if (ct % nr == 0)
                {
                    x = 75;
                    y += 400;
                }

                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }



    }
}
