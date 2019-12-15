using System;
namespace EX3
{
    public class NoSensor
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Nivel { get; set; }
        public double Temperatura { get; set; }

        public NoSensor()
        {
        }

        public NoSensor(int id, double latitude, double longitude, double nivel, double temperatura)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
            Nivel = nivel;
            Temperatura = temperatura;
        }

    }
}
