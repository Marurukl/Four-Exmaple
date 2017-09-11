using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[5];
            int countCars=5;
            for (int i = 0; i < countCars; i++)
            {
                Console.WriteLine("Машина №{0}",i+1);
                car[i] = new Car();
                car[i].Init();
            }
            for (int i = 0; i < countCars; i++)
            {
                Console.WriteLine("Машина №{0}", i + 1);
                car[i].Show();
                Console.WriteLine("  ");
            }
            Console.ReadLine();
        }
    }
}
