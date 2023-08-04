using Mostenirea.Mostenire2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;
using Tema_Mostenire2;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCard:Panel
    {

        Form1 form;
        Electronice electro;

        Label lblType;
        Label lblId;

        Label lblInch;
        Label lblGb;
        Label lblApa;
        Label lblNrCanale;
        Label lblPutere;
        Label lblsmart;
        Button btnDelete;

        ControllerElectro controllerElectro;

        public PnlCard(Form1 form, Electronice electro1)
        {
            this.form = form;
            this.electro = electro1;
            this.controllerElectro = new ControllerElectro();

            //PnlCardPat
            this.Name = "PnlCard";
            this.Size = new System.Drawing.Size(330, 380);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblType = new Label();
            this.lblId = new Label();

            this.lblInch = new Label();
            this.lblGb = new Label();
            this.lblApa = new Label();
            this.lblNrCanale = new Label();
            this.lblPutere = new Label();
            this.lblsmart = new Label();
            this.btnDelete = new Button();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblId);

            this.Controls.Add(this.btnDelete);

            lblType.ForeColor = lblGb.ForeColor = lblId.ForeColor = lblApa.ForeColor =
            lblNrCanale.ForeColor = lblPutere.ForeColor = lblsmart.ForeColor = 
            lblInch.ForeColor = System.Drawing.Color.White;

            if (electro is Mobil)
            {
                this.Controls.Add(this.lblInch);
                this.Controls.Add(this.lblGb);

                Mobil mobil  = electro as Mobil;
                //lblNum
                this.lblInch.AutoSize = true;
                this.lblInch.Location = new System.Drawing.Point(46, 140);
                this.lblInch.Text = "Inch: " + mobil.Inch.ToString();

                //lblGb
                this.lblGb.AutoSize = true;
                this.lblGb.Location = new System.Drawing.Point(46, 203);
                this.lblGb.Text = "Gb: " + mobil.Gb.ToString();

            }

            else if (electro is SmartWatch)
            {
                this.Controls.Add(this.lblInch);
                this.Controls.Add(this.lblApa);
                SmartWatch a = electro as SmartWatch;
                //lblNum
                this.lblInch.AutoSize = true;
                this.lblInch.Location = new System.Drawing.Point(46, 140);
                this.lblInch.Text = "Inch: " + a.Inch.ToString();

                //lblApa
                this.lblApa.AutoSize = true;
                this.lblApa.Location = new System.Drawing.Point(46, 203);
                this.lblApa.Text = "Rezistent apa: " + a.Rezistenta.ToString();

            }

            else if (electro is Televizor)
            {
                this.Controls.Add(this.lblsmart);

                Televizor tel = electro as Televizor;

                //lblSmart
                this.lblsmart.AutoSize = true;
                this.lblsmart.Location = new System.Drawing.Point(46, 140);
                this.lblsmart.Text = "Smart: " + tel.Smart.ToString();

            }

            else if (electro is SoundBar)
            {
                this.Controls.Add(this.lblNrCanale);
                this.Controls.Add(this.lblPutere);

                SoundBar mo = electro as SoundBar;

                //lblNrCanale
                this.lblNrCanale.AutoSize = true;
                this.lblNrCanale.Location = new System.Drawing.Point(46, 140);
                this.lblNrCanale.Text = "Nr Canale: " + mo.NrCanale.ToString();

                //lblPutere
                this.lblPutere.AutoSize = true;
                this.lblPutere.Location = new System.Drawing.Point(46, 203);
                this.lblPutere.Text = "Putere(W): " + mo.PutereW.ToString();
            }

            //lblIType
            this.lblType.Text = "Type: " + electro.Type;
            this.lblType.Location = new System.Drawing.Point(46, 23);
            this.lblType.AutoSize = true;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 77);
            this.lblId.Text = "Id: " + electro.Id.ToString();

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

           controllerElectro.delete(electro.Id);

            form.removepnl("PnlToateCardurile");
            form.Controls.Add(new PnlToateCardurile(form));

        }

    }
}
