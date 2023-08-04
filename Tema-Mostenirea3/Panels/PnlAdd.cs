using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;
using Tema_Mostenirea3;

namespace MostenireWindowsForm.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtRasa;
        private System.Windows.Forms.Label lblRasa;

        private System.Windows.Forms.TextBox txtVede;
        private System.Windows.Forms.Label lblVede;
        private System.Windows.Forms.CheckBox chkTunsa;

        private System.Windows.Forms.TextBox txtGreu;
        private System.Windows.Forms.Label lblGreu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

        ControllerAnimale controllerAnimale;

        public PnlAdd(Form1 form1)
        {


            this.form = form1;
            this.controllerAnimale = new ControllerAnimale();

            // MockupAdd
            this.Size = new System.Drawing.Size(1537, 793);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAdd";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtRasa = new System.Windows.Forms.TextBox();
            this.lblRasa = new System.Windows.Forms.Label();
            this.txtVede = new System.Windows.Forms.TextBox();
            this.lblVede = new System.Windows.Forms.Label();
            this.chkTunsa = new System.Windows.Forms.CheckBox();
            this.txtGreu = new System.Windows.Forms.TextBox();
            this.lblGreu = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtGreu);
            this.Controls.Add(this.lblGreu);
            this.Controls.Add(this.chkTunsa);
            this.Controls.Add(this.txtVede);
            this.Controls.Add(this.lblVede);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtRasa);
            this.Controls.Add(this.lblRasa);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);

            this.txtVede.Visible = false;
            this.lblVede.Visible = false;
            this.lblGreu.Visible = false;
            this.txtGreu.Visible = false;
            this.chkTunsa.Visible = false;

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
            this.cmbType.Items.Add("caine");
            this.cmbType.Items.Add("pisica");
            this.cmbType.Items.Add("oaie");
            this.cmbType.Items.Add("papagal");
            this.cmbType.Text = "caine";
            this.cmbType.SelectedIndexChanged += new EventHandler(cmbType_SelectedIndexChanged);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNume.Location = new System.Drawing.Point(985, 42);
            this.lblNume.Size = new System.Drawing.Size(101, 41);
            this.lblNume.Text = "Nume";

            // txtNume
            this.txtNume.Location = new System.Drawing.Point(909, 101);
            this.txtNume.Size = new System.Drawing.Size(238, 38);

            // txtBrand
            this.txtData.Location = new System.Drawing.Point(104, 287);
            this.txtData.Size = new System.Drawing.Size(238, 38);

            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(146, 228);
            this.lblData.Size = new System.Drawing.Size(160, 41);
            this.lblData.Text = "Data Nasteri";

            // txtRasa
            this.txtRasa.Location = new System.Drawing.Point(588, 287);
            this.txtRasa.Size = new System.Drawing.Size(238, 38);

            // lblRasa
            this.lblRasa.AutoSize = true;
            this.lblRasa.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblRasa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRasa.Location = new System.Drawing.Point(635, 228);
            this.lblRasa.Size = new System.Drawing.Size(130, 41);
            this.lblRasa.Text = "Rasa";

            // txtNrPiloti
            this.txtVede.Location = new System.Drawing.Point(1062, 287);
            this.txtVede.Size = new System.Drawing.Size(238, 38);

            // lblVede
            this.lblVede.AutoSize = true;
            this.lblVede.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblVede.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVede.Location = new System.Drawing.Point(1104, 228);
            this.lblVede.Size = new System.Drawing.Size(148, 41);
            this.lblVede.Text = "Vede";

            // chkhasSidecar
            this.chkTunsa.AutoSize = true;
            this.chkTunsa.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkTunsa.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTunsa.Location = new System.Drawing.Point(909, 424);
            this.chkTunsa.Size = new System.Drawing.Size(206, 45);
            this.chkTunsa.Text = "Este tunsa";

            // txtGreu
            this.txtGreu.Location = new System.Drawing.Point(320, 449);
            this.txtGreu.Size = new System.Drawing.Size(238, 38);

            // lblGreu
            this.lblGreu.AutoSize = true;
            this.lblGreu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblGreu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGreu.Location = new System.Drawing.Point(362, 390);
            this.lblGreu.Size = new System.Drawing.Size(146, 41);
            this.lblGreu.Text = "Greutatea";

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

            if (cmbType.SelectedItem.ToString().Equals("caine"))
            {
                this.txtData.Visible = true;
                this.lblData.Visible = true;
                this.txtGreu.Visible = false;
                this.txtVede.Visible = false;
                this.txtRasa.Visible = true;
                this.lblRasa.Visible = true;
                this.lblGreu.Visible = false;
                this.lblVede.Visible = false;
                this.chkTunsa.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("pisica"))
            {
                this.txtData.Visible = false;
                this.lblData.Visible = false;
                this.txtGreu.Visible = true;
                this.txtVede.Visible = true;
                this.txtRasa.Visible = false;
                this.lblRasa.Visible = false;
                this.lblGreu.Visible = true;
                this.lblVede.Visible = true;
                this.chkTunsa.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("oaie"))
            {
                this.txtData.Visible = false;
                this.lblData.Visible = false;
                this.txtGreu.Visible = false;
                this.txtVede.Visible = false;
                this.txtRasa.Visible = false;
                this.lblRasa.Visible = false;
                this.lblGreu.Visible = false;
                this.lblVede.Visible = false;
                this.chkTunsa.Visible = true;
            }

            if (cmbType.SelectedItem.ToString().Equals("papagal"))
            {
                this.txtData.Visible = false;
                this.lblData.Visible = false;
                this.txtGreu.Visible = true;
                this.txtVede.Visible = false;
                this.txtRasa.Visible = true;
                this.lblRasa.Visible = true;
                this.lblGreu.Visible = true;
                this.lblVede.Visible = false;
                this.chkTunsa.Visible = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            int id = controllerAnimale.generareId();
            string nume = txtNume.Text;

            if (cmbType.SelectedItem.ToString().Equals("caine"))
            {
                string data = txtData.Text;
                string rasa = txtRasa.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + nume + "," + data + "," + rasa;
                controllerAnimale.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("pisica"))
            {
                string vede = txtVede.Text;
                string greu = txtGreu.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + nume + "," + vede + "," + greu;
                controllerAnimale.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("oaie"))
            {
                string tunsa = "false";
                if(chkTunsa.Checked) { tunsa = "true"; }

                string t = cmbType.Text + "," + id.ToString() + "," + nume + "," + tunsa;
                controllerAnimale.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("papagal"))
            {
                string gru = txtGreu.Text;
                string rasa = txtRasa.Text;

                string t = cmbType.Text + "," + id.ToString() + "," + nume + "," + gru + "," + rasa;

                controllerAnimale.save(t);
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
