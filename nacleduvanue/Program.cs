using System;

namespace nacleduvanue
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car(80);
            MiniVan myvan = new MiniVan();
            myvan.Speed = 10;

            mycar.Speed = 50;
            Console.WriteLine("{0}kmh",mycar.Speed);
            Console.WriteLine("{0}kmh", myvan.Speed);

        }
    }
}
