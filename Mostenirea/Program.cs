using Mostenirea.Mostenire1;
using Mostenirea.Mostenire2;

class Program
{
    static void Main(string[] args)
    {
/*
        Barca barca = new Barca(50);
      //  Avion avion = new Avion();

*/

        Mobil mobil = new Mobil(8,128);
        Mobil mobil1 = new Mobil(7,64);
        Mobil mobil2 = new Mobil(8,100);

        SoundBar soundBar = new SoundBar(4,200);
        SoundBar soundBar1 = new SoundBar(2,120);
        SoundBar soundBar2 = new SoundBar(4,260);

        SmartWatch smartWatch = new SmartWatch(1,true);
        SmartWatch smartWatch1 = new SmartWatch(1,false);

        AparatFoto aparatFoto = new AparatFoto(8,360);
        AparatFoto aparatFoto1 = new AparatFoto(7,260);

        Televizor televizor1 = new Televizor(128,true);
        Televizor televizor2 = new Televizor(80,false);
        Televizor televizor3 = new Televizor(108,true);



      // Console.WriteLine(soundBar.descriereSoundBar());


        //Car myCar = new Car("Toyota", 2020, 4);
        //myCar.DisplayInfo(); // Outputs: Brand: Toyota, Year: 2020
        //myCar.Honk();        // Outputs: Beep beep!
        //myCar.Drive();       // Outputs: The car is driving.

        //Console.WriteLine();

        //Motorcycle myMotorcycle = new Motorcycle("Honda", 2022, false);
        //myMotorcycle.DisplayInfo(); // Outputs: Brand: Honda, Year: 2022
        //myMotorcycle.Honk();        // Outputs: Beep beep!
        //myMotorcycle.Ride();        // Outputs: The motorcycle is riding.

    }
}