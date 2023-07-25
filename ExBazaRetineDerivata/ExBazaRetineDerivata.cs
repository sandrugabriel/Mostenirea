using Mostenirea.Mostenire2;
using Mostenirea.Mostenire3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBazaRetineDerivata
{
    public class ExBazaRetineDerivata
    {
/*
        Mobil mobil = new Mobil(8, 128);
        Mobil mobil1 = new Mobil(7, 64);
        Mobil mobil2 = new Mobil(8, 100);

        SoundBar soundBar = new SoundBar(4, 200);
        SoundBar soundBar1 = new SoundBar(2, 120);
        SoundBar soundBar2 = new SoundBar(4, 260);

        SmartWatch smartWatch = new SmartWatch(1, true);
        SmartWatch smartWatch1 = new SmartWatch(1, false);

        AparatFoto aparatFoto = new AparatFoto(8, 360);
        AparatFoto aparatFoto1 = new AparatFoto(7, 260);

        Televizor televizor1 = new Televizor(128, true);
        Televizor televizor2 = new Televizor(80, false);
        Televizor televizor3 = new Televizor(108, true);
*/
        [Fact]
        public void Return_CalledWhen_PersoaneDif()
        {
            //Given
            Admin admin1 = new Admin(true, 1, "gabi", "1234");
            Admin admin2 = new Admin(false, 2, "ana", "ana123");

            User user1 = new User(19, 3, "test", "tes1234");
            User user2 = new User(18, 4, "test2", "test21234");


            Persoane pers = admin1;

            pers.Id = 12;


            Console.WriteLine(  admin1.Id);


            List<Persoane> persoane = new List<Persoane>();

            persoane.Add(admin1);
            persoane.Add(admin2);
            persoane.Add(user1);
            persoane.Add(user2);

            int ctUser = 0;
            int ctAdmin = 0;
            for(int i=0;i<persoane.Count;i++)
            {
                Console.WriteLine(persoane[i].descriere());
                if (persoane[i] is Admin){
                    //conversie de la  baza la deriivta
                    Console.WriteLine("intrat");
                    ctAdmin++;
                }

                if (persoane[i] is User)
                {
                    ctUser++;
                }

            }



        }


    }
}
