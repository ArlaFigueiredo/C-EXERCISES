using System;
namespace EX3
{
    public class NoSensor
    {
        private int Id { get; set; }
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        private double Nivel { get; set; }
        private double Temperatura { get; set; }

        public NoSensor()
        {
            this.setId(0);
            this.setLatitude(0);
            this.setLongitude(0);
            this.setNivel(0);
            this.setTemperatura(0);
        }

        public NoSensor(int id, double latitude, double longitude, double nivel, double temperatura)
        {
            this.setId(id);
            this.setLatitude(latitude);
            this.setLongitude(longitude);
            this.setNivel(nivel);
            this.setTemperatura(temperatura);
        }

        public void setTemperatura(double temperatura)
        {
            this.Temperatura = temperatura;
        }

        public double getTemperatura()
        {
            return this.Temperatura;
        }

        public void setId(int  id)
        {
            this.Id = id;
        }

        public double getId()
        {
            return this.Id;
        }

        public void setLatitude(double latitude)
        {
            this.Latitude = latitude;
        }

        public double getLatitude()
        {
            return this.Latitude;
        }

        public void setLongitude(double longitude)
        {
            this.Longitude = longitude;
        }

        public double getLongitude()
        {
            return this.Longitude;
        }

        public void setNivel(double nivel)
        {
            this.Nivel = nivel;
        }

        public double getNivel()
        {
            return this.Nivel;
        }

        public double Distancia( NoSensor sensorOutro)
        {
            return Math.Sqrt(Math.Pow(this.getLatitude() - sensorOutro.Latitude, 2.0) + Math.Pow(this.getLongitude() - sensorOutro.Longitude, 2.0) + Math.Pow(this.getNivel() - sensorOutro.Nivel, 2.0));
        }


    }
}

