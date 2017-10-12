using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndPolymorphismWeek3Day3
{
    class Aircraft : Vehicle
    {
        private double altitude;
        
        public Aircraft(int seats, int carryingCap, string color, int movementSpeed)
        { this.seats = seats;
            this.carryingCap = carryingCap;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude: " +altitude+ "-" + base.GetDistanceTraveled();
        }

    }
}
