using System;
using System.Globalization;

namespace EX3
{
    class MainClass
    {
        public static void Main()
        {
            NoSensor sensor = new NoSensor(1,30,40,20,80);
            NoSensor sensorOutro = new NoSensor(2,60,120,50,20);


            Console.WriteLine("A distancia : " + sensor.Distancia(sensorOutro));

        }
    }
}
