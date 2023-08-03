using MostenireWindowsForm.Mostenirea5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCardBirou : Panel
    {

        Form1 form;
        Birou birou;

        Label lblType;
        Label lblId;
        Label lblLatime;
        Label lblInaltime;
        Label lblLungime;


        public PnlCardBirou(Form1 form1, Birou birou1)
        {

            this.form = form1;
            this.birou = birou1;


            //PnlCardBirou
            this.Name = "PnlCardBirou";
            this.Size = new System.Drawing.Size(320, 320);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblInaltime = new Label();
            this.lblLungime = new Label();
            this.lblType = new Label();
            this.lblId = new Label();
            this.lblLatime = new Label();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblLatime);
            this.Controls.Add(this.lblInaltime);

            //lblIType
            this.lblType.Text = "Type: " + birou.Type;
            this.lblType.Location = new System.Drawing.Point(46, 29);
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.White;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 88);
            this.lblId.Text = "Id: " + birou.Id.ToString();
            this.lblId.ForeColor = System.Drawing.Color.White;

            //lblLatime
            this.lblLatime.AutoSize = true;
            this.lblLatime.Location = new System.Drawing.Point(46, 151);
            this.lblLatime.Text = "Latime: " + birou.Lagime.ToString();
            this.lblLatime.ForeColor = System.Drawing.Color.White;

            //lblInaltime
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(46, 219);
            this.lblInaltime.Text = "Inaltime: " + birou.Inaltime.ToString();
            this.lblInaltime.ForeColor = System.Drawing.Color.White;

            //lblLungime
            this.lblLungime.AutoSize = true;
            this.lblLungime.Location = new System.Drawing.Point(46, 279);
            this.lblLungime.Text = "Lungime: " + birou.Lungime.ToString();
            this.lblLungime.ForeColor = System.Drawing.Color.White;



        }


    }
}
