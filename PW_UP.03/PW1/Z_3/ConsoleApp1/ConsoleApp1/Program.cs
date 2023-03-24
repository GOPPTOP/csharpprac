using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_3
{
    class Avtomobil
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance/maxSpeed;

        }
        public void InfAvtomobil()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скорость: {maxSpeed}.");
        }
        public Avtomobil()
        {
            this.name = "Lada";
            this.maxSpeed = 150;
        }
        public Avtomobil(string name, double speed)
        {
            this.name = name;
            this.maxSpeed = speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
