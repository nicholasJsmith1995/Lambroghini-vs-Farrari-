using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using car_class;

namespace CarApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(5);
            Car car2 = new Car(6);

            for (int i = 0; i < 5; i++)
            {
                car1.FerraiAccelerate();
                Console.WriteLine("Ferrari "+car1.Speed);
                
            }
            for (int i = 0; i < 5; i++)
            {
                car1.Brake();
                Console.WriteLine("Ferrai "+car1.Speed);
            }
            for (int i = 0; i < 5; i++)
            {
                car2.LamboAccelerate();
                Console.WriteLine("Lambo "+car2.Speed);
            }
            
            for (int i = 0; i < 5; i++)
            {
                car2.Brake();
                Console.WriteLine("Lambo "+car2.Speed);
            }
            Console.ReadLine();
        }
    }
}
