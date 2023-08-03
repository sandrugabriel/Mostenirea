using MostenireWindowsForm.Mostenirea5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MostenireWindowsForm.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtLungime;
        private System.Windows.Forms.Label lblLungime;
        private System.Windows.Forms.TextBox txtLatimea;
        private System.Windows.Forms.Label lblLatimea;
        private System.Windows.Forms.TextBox txtInaltime;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.CheckBox chkOglinda;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.Label lblCuloare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

        ControllerMobila controllerMobila;

        public PnlAdd(Form1 form1) {
        
            
            this.form = form1;
            this.controllerMobila = new ControllerMobila();

            // MockupAdd
            this.Size = new System.Drawing.Size(1537, 793);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAdd";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtLungime = new System.Windows.Forms.TextBox();
            this.lblLungime = new System.Windows.Forms.Label();
            this.txtLatimea = new System.Windows.Forms.TextBox();
            this.lblLatimea = new System.Windows.Forms.Label();
            this.txtInaltime = new System.Windows.Forms.TextBox();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.chkOglinda = new System.Windows.Forms.CheckBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.lblCuloare = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.chkOglinda);
            this.Controls.Add(this.txtInaltime);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.txtLatimea);
            this.Controls.Add(this.lblLatimea);
            this.Controls.Add(this.txtLungime);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);

            this.txtCuloare.Visible = false;
            this.txtInaltime.Visible = false;
            this.lblCuloare.Visible = false;
            this.lblInaltime.Visible = false;
            this.chkOglinda.Visible = false;

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(399, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(88, 41);
            this.lblType.Text = "Type";
             
            // cmbType
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(320, 101);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(238, 38);
            this.cmbType.Items.Add("pat");
            this.cmbType.Items.Add("dulap");
            this.cmbType.Items.Add("comoda");
            this.cmbType.Items.Add("birou");
            this.cmbType.Text = "pat";
            this.cmbType.SelectedIndexChanged += new EventHandler(cmbType_SelectedIndexChanged);
             
            // lblPret
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblPret.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPret.Location = new System.Drawing.Point(985, 42);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(101, 41);
            this.lblPret.Text = "Pretul";
             
            // txtPret
            this.txtPret.Location = new System.Drawing.Point(909, 101);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(238, 38);
             
            // txtLungime
            this.txtLungime.Location = new System.Drawing.Point(104, 287);
            this.txtLungime.Name = "txtLungime";
            this.txtLungime.Size = new System.Drawing.Size(238, 38);
             
            // lblLungime
            this.lblLungime.AutoSize = true;
            this.lblLungime.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblLungime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLungime.Location = new System.Drawing.Point(146, 228);
            this.lblLungime.Name = "lblLungime";
            this.lblLungime.Size = new System.Drawing.Size(160, 41);
            this.lblLungime.Text = "Lungimea";
             
            // txtLatimea
            this.txtLatimea.Location = new System.Drawing.Point(588, 287);
            this.txtLatimea.Name = "txtLatimea";
            this.txtLatimea.Size = new System.Drawing.Size(238, 38);
             
            // lblLatimea
            this.lblLatimea.AutoSize = true;
            this.lblLatimea.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblLatimea.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLatimea.Location = new System.Drawing.Point(635, 228);
            this.lblLatimea.Name = "lblLatimea";
            this.lblLatimea.Size = new System.Drawing.Size(130, 41);
            this.lblLatimea.Text = "Latimea";
             
            // txtInaltime
            this.txtInaltime.Location = new System.Drawing.Point(1062, 287);
            this.txtInaltime.Name = "txtInaltime";
            this.txtInaltime.Size = new System.Drawing.Size(238, 38);
             
            // lblInaltime
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblInaltime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInaltime.Location = new System.Drawing.Point(1104, 228);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(148, 41);
            this.lblInaltime.Text = "Inaltimea";
             
            // chkOglinda
            this.chkOglinda.AutoSize = true;
            this.chkOglinda.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkOglinda.ForeColor = System.Drawing.SystemColors.Control;
            this.chkOglinda.Location = new System.Drawing.Point(909, 424);
            this.chkOglinda.Name = "chkOglinda";
            this.chkOglinda.Size = new System.Drawing.Size(206, 45);
            this.chkOglinda.Text = "Are oglinda";
             
            // txtCuloare
            this.txtCuloare.Location = new System.Drawing.Point(320, 449);
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(238, 38);
             
            // lblCuloare
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblCuloare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCuloare.Location = new System.Drawing.Point(362, 390);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(146, 41);
            this.lblCuloare.Text = "Culoarea";
            
            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(141, 668);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 79);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            // btnAdd
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(1120, 678);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 79);
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbType.SelectedItem.ToString().Equals("dulap"))
            {
                this.txtCuloare.Visible = false;
                this.txtInaltime.Visible = true;
                this.txtLatimea.Visible = false;
                this.txtLungime.Visible = true;
                this.lblCuloare.Visible = false;
                this.lblInaltime.Visible = true;
                this.lblLungime.Visible = true;
                this.lblLatimea.Visible = false;
                this.chkOglinda.Visible = true;
            }

            if (cmbType.SelectedItem.ToString().Equals("pat"))
            {
                this.txtCuloare.Visible = false;
                this.txtInaltime.Visible = false;
                this.txtLatimea.Visible = true;
                this.txtLungime.Visible = true;
                this.lblCuloare.Visible = false;
                this.lblInaltime.Visible = false;
                this.lblLungime.Visible = true;
                this.lblLatimea.Visible = true;
                this.chkOglinda.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("comoda"))
            {
                this.txtCuloare.Visible = true;
                this.txtInaltime.Visible = true;
                this.txtLatimea.Visible = false;
                this.txtLungime.Visible = true;
                this.lblCuloare.Visible = true;
                this.lblInaltime.Visible = true;
                this.lblLungime.Visible = true;
                this.lblLatimea.Visible = false;
                this.chkOglinda.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("birou"))
            {
                this.txtCuloare.Visible = false;
                this.txtInaltime.Visible = true;
                this.txtLatimea.Visible = true;
                this.txtLungime.Visible = true;
                this.lblCuloare.Visible = false;
                this.lblInaltime.Visible = true;
                this.lblLungime.Visible = true;
                this.lblLatimea.Visible = true;
                this.chkOglinda.Visible = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e) {


            int id = controllerMobila.generareId();
            string pretul = txtPret.Text;

            if (cmbType.SelectedItem.ToString().Equals("dulap"))
            {
                string inaltime = txtInaltime.Text;
                string lungime = txtLungime.Text;
                string ogl = "false";
                if (chkOglinda.Checked)
                {
                    ogl = "true";
                }
                string t = cmbType.Text + "," + id.ToString() + "," + pretul + "," + ogl + "," + inaltime + "," + lungime;
                controllerMobila.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("pat"))
            {
                string latime = txtLatimea.Text;
                string lungime = txtLungime.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + pretul + "," + latime + "," + lungime;
                controllerMobila.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("comoda"))
            {
                string culoare = txtCuloare.Text;
                string inaltime = txtInaltime.Text;
                string lungime = txtLungime.Text;

                string t = cmbType.Text + "," + id.ToString() + "," + pretul + "," + culoare + "," + inaltime + "," + lungime;
                controllerMobila.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("birou"))
            {
                string latime = txtLatimea.Text;
                string inaltime = txtInaltime.Text;
                string lungime = txtLungime.Text;

                string t = cmbType.Text + "," + id.ToString() + "," + pretul + "," + inaltime + "," + lungime + "," + latime;

                controllerMobila.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlAdd");
            this.form.Controls.Add(new PnlToateCardurile(form));
            this.form.Controls.Add(new PnlMeniu(form));

        }

    }
}
