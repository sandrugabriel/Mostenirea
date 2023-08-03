using MostenireWindowsForm.Mostenirea5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCardDulap:Panel
    {

        Form1 form;

        Label lblType;
        Label lblId;
        Label lblOglinda;
        Label lblInaltime;
        Label lblLungime;

        Dulap dulap;
        Button btnDelete;

        ControllerMobila controllerMobila;

        public PnlCardDulap(Form1 form1, Dulap dulap1)
        {

            this.form = form1;
            this.dulap = dulap1;
            this.controllerMobila = new ControllerMobila();

            //PnlCardDulap
            this.Name = "PnlCardDulap";
            this.Size = new System.Drawing.Size(320, 320);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblInaltime = new Label();
            this.lblLungime = new Label();
            this.lblType = new Label();
            this.lblId = new Label();
            this.lblOglinda = new Label();
            this.btnDelete = new Button();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOglinda);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.btnDelete);

            lblType.ForeColor = lblLungime.ForeColor = lblInaltime.ForeColor = lblId.ForeColor = lblOglinda.ForeColor = System.Drawing.Color.White;

            //lblIType
            this.lblType.Text = "Type: " + dulap.Type;
            this.lblType.Location = new System.Drawing.Point(46, 29);
            this.lblType.AutoSize = true;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 88);
            this.lblId.Text = "Id: " + dulap.Id.ToString();

            //lblOglinda
            this.lblOglinda.AutoSize = true;
            this.lblOglinda.Location = new System.Drawing.Point(46, 151);
            this.lblOglinda.Text = "Oglinda? : " + dulap.Oglinda.ToString();

            //lblInaltime
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(46, 219);
            this.lblInaltime.Text = "Inaltime: " + dulap.Inaltime.ToString();

            //lblLungime
            this.lblLungime.AutoSize = true;
            this.lblLungime.Location = new System.Drawing.Point(46, 279);
            this.lblLungime.Text = "Lungime: " + dulap.Lungime.ToString();

            //btnDelete
            this.btnDelete.Location = new System.Drawing.Point(175, 15);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(120, 50);
            this.btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
            this.btnDelete.Click += new EventHandler(btnDelete_Click);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            controllerMobila.delete(dulap.Id);

            form.removepnl("PnlToateCardurile");
            form.Controls.Add(new PnlToateCardurile(form));


        }



    }
}
