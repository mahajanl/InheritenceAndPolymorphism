using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        public Automobile (int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCap, string color, double movementSpeed)
        {
            //if we leave it like this, we won't be setting any of the fields that we have available in Vehicle until theyre set to protected
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }


    }
}
