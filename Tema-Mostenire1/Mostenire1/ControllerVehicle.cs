using Mostenirea.Mostenire1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_Mostenire1.Mostenire1
{
    internal class ControllerVehicle
    {

        private List<Vehicle> vehicles;

        public ControllerVehicle()
        {

            vehicles = new List<Vehicle>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/vehicle.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {

                switch (t.Split(',')[0])
                {

                    case "car":
                        vehicles.Add(new Car(t));
                        break;
                    case "avion":
                        vehicles.Add(new Avion(t));
                        break;
                    case "barca":
                        vehicles.Add(new Barca(t));
                        break;
                    case "motocicleta":
                        vehicles.Add(new Motorcycle(t));
                        break;

                }

            }

            streamReader.Close();

        }

        public List<Vehicle> getAll()
        {
            return vehicles;
        }

        public Vehicle getVehicleById(int id)
        {

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Id == id)
                {
                    return vehicles[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getVehicleById(id) != null)
            {

                id = random.Next(36, 1000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/vehicle.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < vehicles.Count; i++)
            {

                if (vehicles[i] is Avion)
                {
                    Avion av = vehicles[i] as Avion;
                    t += av.tosave() + "\n";
                }
                else if (vehicles[i] is Car)
                {
                    Car car = vehicles[i] as Car;
                    t += car.tosave() + "\n";
                }
                else if (vehicles[i] is Motorcycle)
                {
                    Motorcycle c = vehicles[i] as Motorcycle;
                    t += c.tosave() + "\n";
                }
                else if (vehicles[i] is Barca)
                {
                    Barca bir = vehicles[i] as Barca;
                    t += bir.tosave() + "\n";
                }
            }


            return t;
        }

        public int pozId(int id)
        {

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Id == id)
                    return i;
            }

            return -1;
        }

        public void stergere(int id)
        {

            int p = pozId(id);

            vehicles.RemoveAt(p);


        }

        public void delete(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/vehicle.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }


    }
}
