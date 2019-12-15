using System.Collections.Generic;
using System;


namespace EX3
{
    public class DistanciaSensor
    {
        public List<NoSensor> Sensores { get; set; } = new List<NoSensor>();

        public DistanciaSensor()
        {
            Sensores = new List<NoSensor>();
        }


        public void AddSensor(NoSensor sensor)
        {
            Sensores.Add(sensor);
        }

        public double Distancia()
        {
            return Math.Sqrt (Math.Pow(Sensores[0].Latitude - Sensores[1].Latitude, 2.0) + Math.Pow(Sensores[0].Longitude - Sensores[1].Longitude, 2.0)+ Math.Pow(Sensores[0].Nivel - Sensores[1].Nivel, 2.0));

        }
    }
}
