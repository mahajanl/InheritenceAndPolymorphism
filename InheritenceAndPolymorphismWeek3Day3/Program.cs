using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Program
    {
        static void Main(string[] args)
        {   Vehicle Truck = new Vehicle(4, 2500, "Blue", 55.0d);

            Truck.Move();
            Truck.Move();
            Console.WriteLine(Truck.DistanceTraveled);

        }


    }
}
