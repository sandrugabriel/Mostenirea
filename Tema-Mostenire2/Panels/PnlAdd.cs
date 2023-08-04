using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;
using Tema_Mostenire2;

namespace MostenireWindowsForm.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;

        private System.Windows.Forms.CheckBox chkSmart;

        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.Label lblInch;
        private System.Windows.Forms.TextBox txtGb;
        private System.Windows.Forms.Label lblGb;

        private System.Windows.Forms.TextBox txtCanale;
        private System.Windows.Forms.Label lblCanale;
        private System.Windows.Forms.CheckBox chkApa;

        private System.Windows.Forms.TextBox txtPutere;
        private System.Windows.Forms.Label lblPutere;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

        ControllerElectro controllerVehicle;

        public PnlAdd(Form1 form1) {
        
            
            this.form = form1;
            this.controllerVehicle = new ControllerElectro();

            // MockupAdd
            this.Size = new System.Drawing.Size(1537, 793);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAdd";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.chkSmart = new System.Windows.Forms.CheckBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.lblInch = new System.Windows.Forms.Label();
            this.txtGb = new System.Windows.Forms.TextBox();
            this.lblGb = new System.Windows.Forms.Label();
            this.txtCanale = new System.Windows.Forms.TextBox();
            this.lblCanale = new System.Windows.Forms.Label();
            this.chkApa = new System.Windows.Forms.CheckBox();
            this.txtPutere = new System.Windows.Forms.TextBox();
            this.lblPutere = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPutere);
            this.Controls.Add(this.lblPutere);
            this.Controls.Add(this.chkApa);
            this.Controls.Add(this.txtCanale);
            this.Controls.Add(this.lblCanale);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.lblInch);
            this.Controls.Add(this.txtGb);
            this.Controls.Add(this.lblGb);
            this.Controls.Add(this.chkSmart);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);

            this.txtPutere.Visible = false;
            this.txtCanale.Visible = false;
            this.lblPutere.Visible = false;
            this.lblCanale.Visible = false;
            this.chkApa.Visible = false;

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
            this.cmbType.Items.Add("mobil");
            this.cmbType.Items.Add("watch");
            this.cmbType.Items.Add("soundbar");
            this.cmbType.Items.Add("televizor");
            this.cmbType.Text = "mobil";
            this.cmbType.SelectedIndexChanged += new EventHandler(cmbType_SelectedIndexChanged);

            //chkSmart
            this.chkSmart.AutoSize = true;
            this.chkSmart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkSmart.ForeColor = System.Drawing.SystemColors.Control;
            this.chkSmart.Location = new System.Drawing.Point(985, 47);
            this.chkSmart.Text = "Este smart?";
            this.chkSmart.Visible = false;
             
            // txtBrand
            this.txtInch.Location = new System.Drawing.Point(104, 287);
            this.txtInch.Size = new System.Drawing.Size(238, 38);
             
            // lblInch
            this.lblInch.AutoSize = true;
            this.lblInch.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblInch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInch.Location = new System.Drawing.Point(146, 228);
            this.lblInch.Size = new System.Drawing.Size(160, 41);
            this.lblInch.Text = "Inch";

            // txtNrLocuri
            this.txtGb.Location = new System.Drawing.Point(588, 287);
            this.txtGb.Size = new System.Drawing.Size(238, 38);

            // lblNrLocuri
            this.lblGb.AutoSize = true;
            this.lblGb.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblGb.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGb.Location = new System.Drawing.Point(635, 228);
            this.lblGb.Size = new System.Drawing.Size(130, 41);
            this.lblGb.Text = "Gb";

            // txtNrPiloti
            this.txtCanale.Location = new System.Drawing.Point(1062, 287);
            this.txtCanale.Size = new System.Drawing.Size(238, 38);

            // lblNrPiloti
            this.lblCanale.AutoSize = true;
            this.lblCanale.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblCanale.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCanale.Location = new System.Drawing.Point(1104, 228);
            this.lblCanale.Size = new System.Drawing.Size(148, 41);
            this.lblCanale.Text = "Nr canale";

            // chkhasSidecar
            this.chkApa.AutoSize = true;
            this.chkApa.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkApa.ForeColor = System.Drawing.SystemColors.Control;
            this.chkApa.Location = new System.Drawing.Point(909, 424);
            this.chkApa.Size = new System.Drawing.Size(206, 45);
            this.chkApa.Text = "Rezistent la apa";

            // txtnumOfDoors
            this.txtPutere.Location = new System.Drawing.Point(320, 449);
            this.txtPutere.Size = new System.Drawing.Size(238, 38);

            // lblnumOfDoors
            this.lblPutere.AutoSize = true;
            this.lblPutere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblPutere.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPutere.Location = new System.Drawing.Point(362, 390);
            this.lblPutere.Size = new System.Drawing.Size(146, 41);
            this.lblPutere.Text = "Putere(W)";
            
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

            if (cmbType.SelectedItem.ToString().Equals("mobil"))
            {
                this.lblInch.Visible = true;
                this.txtInch.Visible = true;
                this.txtPutere.Visible = false;
                this.txtCanale.Visible = false;
                this.txtGb.Visible = true;
                this.lblGb.Visible = true;
                this.lblCanale.Visible = false;
                this.lblPutere.Visible = false;
                this.chkApa.Visible = false;
                this.chkSmart.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("watch"))
            {
                this.lblInch.Visible = true;
                this.txtInch.Visible = true;
                this.txtPutere.Visible = false;
                this.txtCanale.Visible = false;
                this.txtGb.Visible = false;
                this.lblGb.Visible = false;
                this.lblCanale.Visible = false;
                this.lblPutere.Visible = false;
                this.chkApa.Visible = true;
                this.chkSmart.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("soundbar"))
            {
                this.lblInch.Visible = false;
                this.txtInch.Visible = false;
                this.txtPutere.Visible = true;
                this.txtCanale.Visible = true;
                this.txtGb.Visible = false;
                this.lblGb.Visible = false;
                this.lblCanale.Visible = true;
                this.lblPutere.Visible = true;
                this.chkApa.Visible = false;
                this.chkSmart.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("televizor"))
            {
                this.lblInch.Visible = false;
                this.txtInch.Visible = false;
                this.txtPutere.Visible = false;
                this.txtCanale.Visible = false;
                this.txtGb.Visible = false;
                this.lblGb.Visible = false;
                this.lblCanale.Visible = false;
                this.lblPutere.Visible = false;
                this.chkApa.Visible = false;
                this.chkSmart.Visible = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e) {


            int id = controllerVehicle.generareId();

            if (cmbType.SelectedItem.ToString().Equals("mobil"))
            {
                string inch = txtInch.Text;
                string gb = txtGb.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + inch + "," + gb;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("watch"))
            {
                string inch = txtInch.Text;
                string rez = "false";
                if (chkApa.Checked) { rez =  "true"; }

                string t = cmbType.Text + "," + id.ToString() + "," + inch + "," + rez;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("soundbar"))
            {
                string nrcanale = txtCanale.Text;
                string putere = txtPutere.Text;

                string t = cmbType.Text + "," + id.ToString() + "," + nrcanale + "," + putere;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("televizor"))
            {
                string smart = "false";

                if(chkSmart.Checked) { smart = "true"; }

                string t = cmbType.Text + "," + id.ToString() + "," + smart;

                controllerVehicle.save(t);
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
