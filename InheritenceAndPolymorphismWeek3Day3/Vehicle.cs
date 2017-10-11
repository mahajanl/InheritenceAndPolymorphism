using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Vehicle
    {
        protected int seats;
        protected int carryingCap;
        protected string color;
        protected double movementSpeed;
        private float gearRatio;
        private float engineSize;
        protected double distanceTraveled;

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

        public double DistanceTraveled
        { get { return this.distanceTraveled; }
        }


        //CONSTRUCTORS
        public Vehicle ()
        {

        }

        public Vehicle (int seats, int carryingCap, string color, double movementSpeed)
        {   this.seats = seats;
            this.carryingCap = carryingCap;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0d;
            //d at the end because of  a double being entered
        }

        //METHODS
        public void Move()
        {   distanceTraveled += movementSpeed;
        }
        
    }
}
