using System;
using System.Collections.Generic;
using System.Text;

namespace Dersdekiler
{
    internal class HybridCar:Car
    {
        public HybridCar(int fuelCapacity) : base(fuelCapacity)
        {
            Brand = "Prius";
        }

        public int Battery;
    }
}
