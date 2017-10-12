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
        {
            //Vehicle Truck = new Vehicle(4, 2500, "Blue", 55.0d);

            //    Truck.Move();
            //    Truck.Move();
            //    Console.WriteLine(Truck.DistanceTraveled);

            Automobile optimus = new Automobile(6, 25, 4, 4, 3000, "blue", 70.0d);
            optimus.Move();
            optimus.Move();
            Console.WriteLine("Automobile " +optimus.GetDistanceTraveled());

            Boat eclipse = new Boat(2, 440, "Silver", 70.0d, .9d);
            eclipse.Move();
            eclipse.Move();
            Console.WriteLine("Boat " +eclipse.GetDistanceTraveled());

            Aircraft boeing = new Aircraft(70, 30000, "turquoise", 600);
            boeing.Move();
            boeing.Move();
            Console.WriteLine("Airplane " + boeing.GetDistanceTraveled());
        }


    }
}
