using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_3
{
    class Human
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public Human(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Human
    {
        public string Position
        {
            get;
            set;
        }
        public Worker(string name, int age, char gender, string position) : base(name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Valakas = new Human("Жмышенко Валерий", 54, 'М');
            Console.WriteLine(Valakas.Name);
            Worker Svetlana = new Worker("Светлана Неважно", 35, 'Ж', "бухгалтер");
            Console.WriteLine(Svetlana.Position);
            Console.ReadKey(true);
        }
    }
}