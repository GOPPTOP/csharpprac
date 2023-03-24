using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_1
{
    class Avtomobil
    {
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance/maxSpeed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
