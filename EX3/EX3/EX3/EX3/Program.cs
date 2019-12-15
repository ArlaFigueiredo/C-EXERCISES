using System;
using System.Globalization;

namespace EX3
{
    class MainClass
    {
        public static void Main()
        {
            DistanciaSensor distanciasensor = new DistanciaSensor();

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(i);
                int id = int.Parse(Console.ReadLine());
                double latitude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double longitude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double nivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                NoSensor sensor = new NoSensor(id, latitude, longitude, nivel, temperatura);
                distanciasensor.AddSensor(sensor);
            }

            double distancia = distanciasensor.Distancia();
            Console.WriteLine("A distancia entre os sensore eh: " + distancia);

        }
    }
}
