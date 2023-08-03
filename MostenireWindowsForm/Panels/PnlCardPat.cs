using MostenireWindowsForm.Mostenirea5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCardPat:Panel
    {

        Form1 form;
        Pat pat;

        Label lblType;
        Label lblId;
        Label lblLatime;
        Label lblLungime;

        Button btnDelete;

        ControllerMobila controllerMobila;

        public PnlCardPat(Form1 form, Pat pat1)
        {
            this.form = form;
            this.pat = pat1;
            this.controllerMobila = new ControllerMobila();
           // MessageBox.Show("intrat");

            //PnlCardPat
            this.Name = "PnlCardPat";
            this.Size = new System.Drawing.Size(320, 320);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblLatime = new Label();
            this.lblLungime = new Label();
            this.lblType = new Label();
            this.lblId = new Label();
            this.btnDelete = new Button();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblLatime);
            this.Controls.Add(this.btnDelete);

            lblType.ForeColor = lblLungime.ForeColor = lblId.ForeColor = lblLatime.ForeColor = System.Drawing.Color.White;

            //lblIType
            this.lblType.Text = "Type: " + pat.Type;
            this.lblType.Location = new System.Drawing.Point(46, 23);
            this.lblType.AutoSize = true;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 77);
            this.lblId.Text = "Id: " + pat.Id.ToString();

            //lblLatime
            this.lblLatime.AutoSize = true;
            this.lblLatime.Location = new System.Drawing.Point(46, 136);
            this.lblLatime.Text = "Latime: " + pat.Latime.ToString();

            //lblLungime
            this.lblLungime.AutoSize = true;
            this.lblLungime.Location = new System.Drawing.Point(46, 199);
            this.lblLungime.Text = "Lungime: " + pat.Lungime.ToString();

            //btnDelete
            this.btnDelete.Location = new System.Drawing.Point(175,15);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(120,50);
            this.btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
            this.btnDelete.Click += new EventHandler(btnDelete_Click);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            controllerMobila.delete(pat.Id);

            form.removepnl("PnlToateCardurile");
            form.Controls.Add(new PnlToateCardurile(form));

        }

    }
}
