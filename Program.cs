using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismLevel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment();
            Floor[] floors = new Floor[] {
               new Floor(1),
               new Floor(2),
               new Floor(3),
               new Floor(4),
               new Floor(5),
            };
            Elevator[] elevators = new Elevator[]
            {
                new Elevator(1),
                new Elevator(2)
            };

            apartment.floors = floors;
            apartment.elevators = elevators;
            Console.WriteLine(elevators[1].Operate(1, "up", 5, floors, 1));

            Console.ReadKey();
        }
    }
}
