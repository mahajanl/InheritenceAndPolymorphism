using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Boat : Vehicle
    {
        private double waterDrag;

        public Boat(int seats, int carryingCap, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCap = carryingCap;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;

        }

        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }

    }
}
