using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Details
{
    public class Chassis
    {
        public double number_of_wheels;
        public string number;
        public double permissible_load;

        public double NumberOfWheels 
        {
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                number_of_wheels = value;
            }

            get
            {
                return number_of_wheels;
            }
        }

        public string SerialNumber
        {
            set
            {
                number = value ?? throw new ArgumentNullException();
            }
            get
            {
                return number;
            }
        }

        public double PermissibleLoad
        {
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                permissible_load = value;
            }

            get
            {
                return permissible_load;
            }
        }
        public Chassis() { }
        public Chassis(int number_of_wheels, string number, double permissible_load)
        {
            NumberOfWheels = number_of_wheels;
            SerialNumber = number;
            PermissibleLoad = permissible_load;
        }

        public string GetInfo()
        {
            return ("Chassis info: Number of wheels: " + NumberOfWheels + " Serial number: " + SerialNumber
                    + " Permissible load: " + PermissibleLoad);
        }
    }
}
