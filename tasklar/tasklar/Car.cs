using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class Car
    {
        public double FuelCapacity;
        public double CurrentFuel;
        //- AddFuel() - parametr olaraq neçə litr benzin əlavə etmək istənildiyi daxil edilməlidir və capacity-ni aşmırsa əlavə edilməlidir

        public bool AddFuel(double num)
        {
            if (FuelCapacity - CurrentFuel >= num)
            {
                FuelCapacity += num;
                return true;
            }
            return false;
        }
    }
}
