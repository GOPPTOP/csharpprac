using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_2
{
    class PosledNumber
    {
        private int n = 0;
        public int GetNumber(int number)
        {
            if (SetNumber(number))
            {
                this.n = number;
            }
            else
            {
                this.n = 0;
            }
            return this.n;
        }
        private bool SetNumber(int number)
        {
            if (number == this.n + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PosledNumber num = new PosledNumber();
            int number;
            for (int i = 1; i >= 0; i = num.GetNumber(number) + 1)
            {
                Console.WriteLine($"Введите число {i}");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}
