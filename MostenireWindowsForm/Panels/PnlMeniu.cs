using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm.Panels
{
    internal class PnlMeniu:Panel
    {

        Form1 form;

        Label lblTitlu;
        Button btnAdd;

        public PnlMeniu(Form1 form1)
        {

            this.form = form1;

            //PnlMeniu
            this.Size = new System.Drawing.Size(1555, 180);
            this.Name = "PnlMeniu";
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);

            lblTitlu = new Label();
            btnAdd = new Button();

            this.Controls.Add(btnAdd);
            this.Controls.Add(lblTitlu);

            //lblTitlu
            this.lblTitlu.Location = new System.Drawing.Point(662, 43);
            this.lblTitlu.Text = "Mobila";
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 27);
            this.lblTitlu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            //btnAdd
            this.btnAdd.Location = new System.Drawing.Point(1294, 34);
            this.btnAdd.Text = "Adaugare mobila";
            this.btnAdd.Size = new System.Drawing.Size(220, 66);
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



        }

    }
}
