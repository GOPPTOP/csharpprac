using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Z_4
{
    class Avtomobil
    {
        public string name;
        public double maxSpeed;
        private double time1;
        public double time
        {
            get
            {
                return time1;
            }
            set
            {
                time1 = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;

        }
        public void InfAvtomobil()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скорость: {maxSpeed}.");
        }
        public Avtomobil()
        {
            this.name = "Lada";
            this.maxSpeed = 150;
            this.time = 0;
        }
        public Avtomobil(string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Avtomobil[] Avtomobils = new Avtomobil[4];
            double distance = 1000;
            Avtomobil bmw = new Avtomobil("BMW", 250, distance);
            Avtomobils[0] = bmw;
            Avtomobil Subaru = new Avtomobil("Subaru", 270, distance);
            Avtomobils[1] = Subaru;
            Avtomobil Mers = new Avtomobil("Mers", 290, distance);
            Avtomobils[2] = Mers;
            Avtomobil Lamb = new Avtomobil("Lamb", 450, distance);
            Avtomobils[3] = Lamb;
            double[] races = new double[4];
            for (int i = 0; i < Avtomobils.Length; i++)
            {
                races[i] = Avtomobils[i].time;
            }
            Array.Sort(races);
            for (int i = 0; i < races.Length; i++)
            {
                for (int j = 0; j < Avtomobils.Length; j++)
                {
                    if (races[i] == Avtomobils[j].time)
                    {
                        Console.WriteLine($"{i + 1} - {Avtomobils[j].name} скорость {Avtomobils[j].maxSpeed} дистанция {distance} за {Math.Round(Avtomobils[j].time, 2)} ч");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
