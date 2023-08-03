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

        public PnlCardPat(Form1 form, Pat pat1)
        {
            this.form = form;
            this.pat = pat1;
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

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblLatime);

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


      




        }



    }
}
