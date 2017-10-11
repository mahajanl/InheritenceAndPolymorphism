using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Vehicle
    {
        private int seats;
        private int carryingCap;
        private string color;
        private double movementSpeed;
        private float gearRatio;
        private float engineSize;

        //ALL OF OUR SUBCLASSES WILL HAVE THESE THINGS IN COMMON
        public int Seats
        { get { return this.seats; }
        }

        public int CarryingCap
        { get { return this.carryingCap; }
        }

        public string Color
        { get { return this.color; }
          set { this.color = value; }
        }

        //CONSTRUCTORS
        public Vehicle (int seats, int carryingCap, string color, double movementSpeed)
        {   this.seats = seats;
            this.carryingCap = carryingCap;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }

        
    }
}
