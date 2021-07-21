using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Details
{
    class Transmission
    {
        public string type;
        public int number_of_gears;
        public string manufacturer;

        public string Type
        {
            set
            {
                type = value ?? throw new ArgumentNullException();
            }

            get
            {
                return type;
            }
        }
        public int NumberOfGears
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                number_of_gears = value;
            }

            get
            {
                return number_of_gears;
            }
        }

        public string Manufacturer
        {
            set
            {
                manufacturer = value ?? throw new ArgumentNullException();
            }

            get
            {
                return manufacturer;
            }
        }

        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetInfo()
        {
            return ("Transmisssion info: Transmission type: " + Type + " Number of gears: " + NumberOfGears
                    + " Manufacturer: " + Manufacturer);
        }
    }
}
