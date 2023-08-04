using Mostenirea.Mostenire4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;
using Tema_Mostenirea3;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCard:Panel
    {

        Form1 form;
        Animal animal;

        Label lblType;
        Label lblId;
        Label lblNume;

        Label lblData;
        Label lblRasa;
        Label lblVede;
        Label lblGreutatea;
        Label lblTunsa;
        Button btnDelete;

        ControllerAnimale controllerAnimale;

        public PnlCard(Form1 form, Animal animal1)
        {
            this.form = form;
            this.animal = animal1;
            this.controllerAnimale = new ControllerAnimale();

            //PnlCardPat
            this.Name = "PnlCard";
            this.Size = new System.Drawing.Size(330, 380);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblType = new Label();
            this.lblId = new Label();

            this.lblNume = new Label();
            this.lblData = new Label();
            this.lblRasa = new Label();
            this.lblVede = new Label();
            this.lblGreutatea = new Label();
            this.lblTunsa = new Label();
            this.btnDelete = new Button();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNume);

            this.Controls.Add(this.btnDelete);

            lblType.ForeColor = lblData.ForeColor = lblId.ForeColor = lblRasa.ForeColor =
            lblVede.ForeColor = lblGreutatea.ForeColor = lblTunsa.ForeColor = 
            lblNume.ForeColor = System.Drawing.Color.White;

            //lblNum
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(46, 140);
            this.lblNume.Text = "Nume: " + animal.Name.ToString();

            if (animal is Caine)
            {
                this.Controls.Add(this.lblData);
                this.Controls.Add(this.lblRasa);

                Caine caine  = animal as Caine;

                //lblData
                this.lblData.AutoSize = true;
                this.lblData.Location = new System.Drawing.Point(46, 140);
                this.lblData.Text = "Data: " + caine.DataNasteri.ToString();

                //lblRasa
                this.lblRasa.AutoSize = true;
                this.lblRasa.Location = new System.Drawing.Point(46, 203);
                this.lblRasa.Text = "Rasa: " + caine.Rasa.ToString();
            }

            else if (animal is Pisica)
            {
                this.Controls.Add(this.lblVede);
                this.Controls.Add(this.lblGreutatea);

                Pisica a = animal as Pisica;
                //lblNum
                this.lblVede.AutoSize = true;
                this.lblVede.Location = new System.Drawing.Point(46, 140);
                this.lblVede.Text = "Vede: " + a.Vede.ToString();

                //lblApa
                this.lblGreutatea.AutoSize = true;
                this.lblGreutatea.Location = new System.Drawing.Point(46, 203);
                this.lblGreutatea.Text = "Greutatea: " + a.Greutatea.ToString();

            }

            else if (animal is Oaie)
            {
                this.Controls.Add(this.lblTunsa);
                Oaie oaie = animal as Oaie;

                //lblTunsa
                this.lblTunsa.AutoSize = true;
                this.lblTunsa.Location = new System.Drawing.Point(46, 140);
                this.lblTunsa.Text = "Tunsa: " + oaie.Tunsa.ToString();

            }

            else if (animal is Papagal)
            {
                this.Controls.Add(this.lblRasa);
                this.Controls.Add(this.lblGreutatea);

                Papagal mo = animal as Papagal;

                //lblNrCanale
                this.lblRasa.AutoSize = true;
                this.lblRasa.Location = new System.Drawing.Point(46, 140);
                this.lblRasa.Text = "Rasa: " + mo.Rasa.ToString();

                //lblPutere
                this.lblGreutatea.AutoSize = true;
                this.lblGreutatea.Location = new System.Drawing.Point(46, 203);
                this.lblGreutatea.Text = "Greutatea: " + mo.Greutatea.ToString();
            }

            //lblIType
            this.lblType.Text = "Type: " + animal.Type;
            this.lblType.Location = new System.Drawing.Point(46, 23);
            this.lblType.AutoSize = true;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 77);
            this.lblId.Text = "Id: " + animal.Id.ToString();

            //btnDelete
            this.btnDelete.Location = new System.Drawing.Point(48,273);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(120,50);
            this.btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
            this.btnDelete.Click += new EventHandler(btnDelete_Click);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           controllerAnimale.delete(animal.Id);

            form.removepnl("PnlToateCardurile");
            form.Controls.Add(new PnlToateCardurile(form));

        }

    }
}
