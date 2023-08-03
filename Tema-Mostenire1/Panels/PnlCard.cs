using Mostenirea.Mostenire1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema_Mostenire1;
using Tema_Mostenire1.Mostenire1;

namespace MostenireWindowsForm.Panels
{
    internal class PnlCard:Panel
    {

        Form1 form;
        Vehicle vehicle;

        Label lblType;
        Label lblId;
        Label lblBrand;
        Label lblYear;
        Label lblNrLocuri;
        Label lblNrPiloti;
        Label lblnumOfDoors;
        Label lblhasSidecar;
        Button btnDelete;

        ControllerVehicle controllerVehicle;

        public PnlCard(Form1 form, Vehicle vehicle1)
        {
            this.form = form;
            this.vehicle = vehicle1;
            this.controllerVehicle = new ControllerVehicle();

            //PnlCardPat
            this.Name = "PnlCard";
            this.Size = new System.Drawing.Size(330, 380);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.lblBrand = new Label();
            this.lblhasSidecar = new Label();
            this.lblType = new Label();
            this.lblId = new Label();
            this.lblNrPiloti = new Label();
            this.lblnumOfDoors = new Label();
            this.lblNrLocuri = new Label();
            this.lblYear = new Label();
            this.btnDelete = new Button();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblYear);

            this.Controls.Add(this.btnDelete);

            lblType.ForeColor = lblBrand.ForeColor = lblId.ForeColor = lblYear.ForeColor =
            lblnumOfDoors.ForeColor = lblNrPiloti.ForeColor = lblNrLocuri.ForeColor = 
            lblhasSidecar.ForeColor = System.Drawing.Color.White;

            if (vehicle is Car)
            {
                this.Controls.Add(this.lblnumOfDoors);
                Car car  = vehicle as Car;
                //lblNum
                this.lblnumOfDoors.AutoSize = true;
                this.lblnumOfDoors.Location = new System.Drawing.Point(46, 262);
                this.lblnumOfDoors.Text = "Numarul usilor: " + car.NumOfDoors.ToString();
            }

            else if (vehicle is Avion)
            {
                this.Controls.Add(this.lblNrPiloti);
                this.Controls.Add(this.lblNrLocuri);
                Avion avion = vehicle as Avion;
                //lblNrpiloti
                this.lblNrPiloti.AutoSize = true;
                this.lblNrPiloti.Location = new System.Drawing.Point(46, 262);
                this.lblNrPiloti.Text = "Nr pilotilor: " + avion.Nrpiloti.ToString();

                //lblNr
                this.lblNrLocuri.AutoSize = true;
                this.lblNrLocuri.Location = new System.Drawing.Point(46, 325);
                this.lblNrLocuri.Text = "Nr locurilor: " + avion.NrLocuri.ToString();

            }

            else if (vehicle is Barca)
            {
                this.Controls.Add(this.lblNrLocuri);

                Barca barca = vehicle as Barca;

                //lblNr
                this.lblNrLocuri.AutoSize = true;
                this.lblNrLocuri.Location = new System.Drawing.Point(46, 262);
                this.lblNrLocuri.Text = "Nr locurilor: " + barca.NrLocuri.ToString();

            }

            else if (vehicle is Motorcycle)
            {
                this.Controls.Add(this.lblhasSidecar);

                Motorcycle mo = vehicle as Motorcycle;

                //lblNr
                this.lblhasSidecar.AutoSize = true;
                this.lblhasSidecar.Location = new System.Drawing.Point(46, 262);
                this.lblhasSidecar.Text = "Are SideCar: " + mo.HasSidecar.ToString();

            }

            //lblIType
            this.lblType.Text = "Type: " + vehicle.Type;
            this.lblType.Location = new System.Drawing.Point(46, 23);
            this.lblType.AutoSize = true;

            //lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 77);
            this.lblId.Text = "Id: " + vehicle.Id.ToString();

            //lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(46, 136);
            this.lblBrand.Text = "Brandul: " + vehicle.Brand.ToString();

            //lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(46, 199);
            this.lblYear.Text = "Anul: " + vehicle.Year.ToString();

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

           controllerVehicle.delete(vehicle.Id);

            form.removepnl("PnlToateCardurile");
            form.Controls.Add(new PnlToateCardurile(form));

        }

    }
}
