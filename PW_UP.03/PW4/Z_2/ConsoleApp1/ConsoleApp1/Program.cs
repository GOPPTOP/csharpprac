using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_2
{
    class Package
    {
        public string Description
        {
            get;
            private set;
        }
        public int Weight
        {
            get;
            private set;
        }
        public Package(string description, int weight)
        {
            Description = description;
            Weight = weight;
        }
    }
    class SendingService
    {
        private static int LimitWeight;
        private const int Limit = 10;
        public void SendPackage(Package package)
        {
            LimitWeight += package.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Вес отправленных посылок слишком большой, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", package.Description, package.Weight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Package package_1 = new Package("Первая посылка", 4);
            Package package_2 = new Package("Вторая тяжелая посылка", 7);
            SendingService sendingService = new SendingService();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey(true);
        }
    }
}
