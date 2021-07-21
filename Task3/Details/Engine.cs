using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Details
{
    class Engine
    {
        public double power;
        public double volume;
        public string type;
        public string serial_number;

        public double Power
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                power = value;
            }

            get
            {
                return power;
            }
        }

        public double Volume
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                volume = value;
            }

            get
            {
                return volume;
            }
        }

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

        public string SerialNumber
        {
            set
            {
                serial_number = value ?? throw new ArgumentNullException();
            }

            get
            {
                return serial_number;
            }
        }

        public Engine EngineType { get; set; }

        public Engine(double power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            return ("Engine info: Power: " + Power + " Capacity: " + Volume
                    + " Type: " + Type + " Serial number: " + SerialNumber);
        }
    }
}
