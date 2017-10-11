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
    }
}
