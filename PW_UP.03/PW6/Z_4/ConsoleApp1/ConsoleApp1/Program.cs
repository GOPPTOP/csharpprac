using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_4
{
    class JOB
    {
        public int Distance
        {
            get;
            set;
        }
        public int Salary
        {
            get;
            set;
        }
        public JOB(int distance, int salary)
        {
            Distance = distance;
            Salary = salary;
        }
    }
    class OEMKA : JOB
    {
        public void trolley()
        {
            Console.WriteLine("Катимся на трамвае до ОЭМК");
        }
        public OEMKA(int distance, int salary) : base(distance, salary)
        {
        }
    }
    class TeploEnergo : JOB
    {
        public void Marshrutka()
        {
            Console.WriteLine("Давимся в маршрутке с бабками");
        }
        public TeploEnergo(int distance, int salary) : base(distance, salary)
        {
        }
    }
    class Slovyanka : JOB
    {
        public void WalkinLikeATolkin()
        {
            Console.WriteLine("Уверенно в 6 утра шагаем пешечком в наушничках до любимой Словяночки. Зато зп дадут))");
        }
        public Slovyanka(int distance, int salary) : base(distance, salary)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            JOB Polyteh = new JOB(0, 0);
            OEMKA Relsy = new OEMKA(60, 15000);
            Relsy.trolley();
            TeploEnergo trassa = new TeploEnergo(30, 0);
            trassa.Marshrutka();
            Slovyanka nogi = new Slovyanka(10, 15000);
            nogi.WalkinLikeATolkin();
            Console.ReadKey(true);
        }
    }
}