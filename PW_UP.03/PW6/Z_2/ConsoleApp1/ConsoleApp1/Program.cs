using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_2
{
    class TransportVehicle
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public TransportVehicle(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytehMachine : TransportVehicle
    {
        public void TurnMusic()
        {
            Console.WriteLine("Бассбустед. Хана политеховским");
        }
        public PolytehMachine(string name, int speed) : base(name, speed)
        {
        }
    }
    class Airplane : TransportVehicle
    {
        public void OpilyaemPole()
        {
            Console.WriteLine("Поле раскумарено");
        }
        public Airplane(string name, int speed) : base(name, speed)
        {
        }
    }
    class Betonomeshalka : TransportVehicle
    {
        public void MeshaemBeton()
        {
            Console.WriteLine("Мешааааает бетон");
        }
        public Betonomeshalka(string name, int speed) : base(name, speed)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportVehicle Car = new TransportVehicle("Матис на газу", 80);
            PolytehMachine Polytech = new PolytehMachine("Политех-машина", 150);
            Polytech.TurnMusic();
            Airplane Boeing = new Airplane("Боинг 767-223ER", 1000);
            Boeing.OpilyaemPole();
            Betonomeshalka beton = new Betonomeshalka("Цунами", 150);
            beton.MeshaemBeton();
            Console.ReadKey(true);
        }
    }
}