using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;

namespace MostenireWindowsForm.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtNrLocuri;
        private System.Windows.Forms.Label lblNrLocuri;

        private System.Windows.Forms.TextBox txtNrPiloti;
        private System.Windows.Forms.Label lblNrPiloti;
        private System.Windows.Forms.CheckBox chkhasSidecar;

        private System.Windows.Forms.TextBox txtnumOfDoors;
        private System.Windows.Forms.Label lblnumOfDoors;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

        ControllerVehicle controllerVehicle;

        public PnlAdd(Form1 form1) {
        
            
            this.form = form1;
            this.controllerVehicle = new ControllerVehicle();

            // MockupAdd
            this.Size = new System.Drawing.Size(1537, 793);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAdd";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtNrLocuri = new System.Windows.Forms.TextBox();
            this.lblNrLocuri = new System.Windows.Forms.Label();
            this.txtNrPiloti = new System.Windows.Forms.TextBox();
            this.lblNrPiloti = new System.Windows.Forms.Label();
            this.chkhasSidecar = new System.Windows.Forms.CheckBox();
            this.txtnumOfDoors = new System.Windows.Forms.TextBox();
            this.lblnumOfDoors = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtnumOfDoors);
            this.Controls.Add(this.lblnumOfDoors);
            this.Controls.Add(this.chkhasSidecar);
            this.Controls.Add(this.txtNrPiloti);
            this.Controls.Add(this.lblNrPiloti);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtNrLocuri);
            this.Controls.Add(this.lblNrLocuri);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);

            this.txtnumOfDoors.Visible = false;
            this.txtNrPiloti.Visible = false;
            this.lblnumOfDoors.Visible = false;
            this.lblNrPiloti.Visible = false;
            this.chkhasSidecar.Visible = false;

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
            this.cmbType.Items.Add("car");
            this.cmbType.Items.Add("avion");
            this.cmbType.Items.Add("barca");
            this.cmbType.Items.Add("motocicleta");
            this.cmbType.Text = "car";
            this.cmbType.SelectedIndexChanged += new EventHandler(cmbType_SelectedIndexChanged);
             
            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(985, 42);
            this.lblYear.Size = new System.Drawing.Size(101, 41);
            this.lblYear.Text = "Year";
             
            // txtYear
            this.txtYear.Location = new System.Drawing.Point(909, 101);
            this.txtYear.Size = new System.Drawing.Size(238, 38);
             
            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(104, 287);
            this.txtBrand.Size = new System.Drawing.Size(238, 38);
             
            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrand.Location = new System.Drawing.Point(146, 228);
            this.lblBrand.Size = new System.Drawing.Size(160, 41);
            this.lblBrand.Text = "Brandul";

            // txtNrLocuri
            this.txtNrLocuri.Location = new System.Drawing.Point(588, 287);
            this.txtNrLocuri.Size = new System.Drawing.Size(238, 38);

            // lblNrLocuri
            this.lblNrLocuri.AutoSize = true;
            this.lblNrLocuri.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblNrLocuri.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNrLocuri.Location = new System.Drawing.Point(635, 228);
            this.lblNrLocuri.Size = new System.Drawing.Size(130, 41);
            this.lblNrLocuri.Text = "Nr locuri";

            // txtNrPiloti
            this.txtNrPiloti.Location = new System.Drawing.Point(1062, 287);
            this.txtNrPiloti.Size = new System.Drawing.Size(238, 38);

            // lblNrPiloti
            this.lblNrPiloti.AutoSize = true;
            this.lblNrPiloti.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblNrPiloti.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNrPiloti.Location = new System.Drawing.Point(1104, 228);
            this.lblNrPiloti.Size = new System.Drawing.Size(148, 41);
            this.lblNrPiloti.Text = "Nr piloti";

            // chkhasSidecar
            this.chkhasSidecar.AutoSize = true;
            this.chkhasSidecar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkhasSidecar.ForeColor = System.Drawing.SystemColors.Control;
            this.chkhasSidecar.Location = new System.Drawing.Point(909, 424);
            this.chkhasSidecar.Size = new System.Drawing.Size(206, 45);
            this.chkhasSidecar.Text = "Are SideCar";

            // txtnumOfDoors
            this.txtnumOfDoors.Location = new System.Drawing.Point(320, 449);
            this.txtnumOfDoors.Size = new System.Drawing.Size(238, 38);

            // lblnumOfDoors
            this.lblnumOfDoors.AutoSize = true;
            this.lblnumOfDoors.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.lblnumOfDoors.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnumOfDoors.Location = new System.Drawing.Point(362, 390);
            this.lblnumOfDoors.Size = new System.Drawing.Size(146, 41);
            this.lblnumOfDoors.Text = "Nr usilor";
            
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

            if (cmbType.SelectedItem.ToString().Equals("car"))
            {
                this.txtnumOfDoors.Visible = true;
                this.txtNrPiloti.Visible = false;
                this.txtNrLocuri.Visible = false;
                this.lblNrLocuri.Visible = false;
                this.lblNrPiloti.Visible = false;
                this.lblnumOfDoors.Visible = true;
                this.chkhasSidecar.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("barca"))
            {
                this.txtnumOfDoors.Visible = false;
                this.txtNrPiloti.Visible = false;
                this.txtNrLocuri.Visible = true;
                this.lblNrLocuri.Visible = true;
                this.lblNrPiloti.Visible = false;
                this.lblnumOfDoors.Visible = false;
                this.chkhasSidecar.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("avion"))
            {
                this.txtnumOfDoors.Visible = false;
                this.txtNrPiloti.Visible = true;
                this.txtNrLocuri.Visible = true;
                this.lblNrLocuri.Visible = true;
                this.lblNrPiloti.Visible = true;
                this.lblnumOfDoors.Visible = false;
                this.chkhasSidecar.Visible = false;
            }

            if (cmbType.SelectedItem.ToString().Equals("motocicleta"))
            {
                this.txtnumOfDoors.Visible = false;
                this.txtNrPiloti.Visible = false;
                this.txtNrLocuri.Visible = false;
                this.lblNrLocuri.Visible = false;
                this.lblNrPiloti.Visible = false;
                this.lblnumOfDoors.Visible = false;
                this.chkhasSidecar.Visible = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e) {


            int id = controllerVehicle.generareId();
            string year = txtYear.Text;
            string brand =txtBrand.Text;

            if (cmbType.SelectedItem.ToString().Equals("avion"))
            {
                string nrpilot = txtNrPiloti.Text;
                string nrloc = txtNrLocuri.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + brand + "," + year + "," + nrloc + "," + nrpilot;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("car"))
            {
                string doors = txtnumOfDoors.Text;
                string t = cmbType.Text + "," + id.ToString() + "," + brand + "," + year + "," + doors;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("barca"))
            {
                string nrloc = txtNrLocuri.Text;

                string t = cmbType.Text + "," + id.ToString() + "," + brand + "," + year + "," + nrloc;
                controllerVehicle.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form));
                form.Controls.Add(new PnlToateCardurile(form));
            }

            else if (cmbType.SelectedItem.ToString().Equals("motocicleta"))
            {
                string sidecar = "false";

                if(chkhasSidecar.Checked) { sidecar = "true"; }

                string t = cmbType.Text + "," + id.ToString() + "," + brand + "," + year + "," + sidecar;

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
