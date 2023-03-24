using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_4
{
     class Program
    {
        class MyIntList
        {
            private List<int> numbersList = new List<int>();
            public int Sum
            {
                get
                {
                    return CalculateSum();
                }
            }
            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }
            public void AddNumber(int number)
            {
                numbersList.Add(number);
            }
            public void RemoveNumber(int number)
            {
                numbersList.Remove(number);
            }
            private int CalculateSum()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                return sum;
            }
            private double CalculateAverage()
            {
                return Sum / (double)numbersList.Count;
            }
        }
        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();
            numbers.AddNumber(100);
            numbers.AddNumber(200);
            numbers.AddNumber(4);
            numbers.AddNumber(28);
            numbers.AddNumber(3);
            Console.WriteLine(numbers.Sum);
            Console.WriteLine(numbers.Average);
            Console.ReadKey(true);
        }
    }
}
