using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        // properties
        public bool IsOn { get; set; }
        public bool IsOff { get; set; }


        // field variables
        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;

        private int volume;
        private double frequency;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > maxVolume)
                {
                    Console.WriteLine("Volume is too big, set to max!");
                }

                else if (value < minVolume)
                {
                    Console.WriteLine("Volume is too low, set to min!");
                }

                else
                {
                    volume = value;
                }
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value > frequency)
                {
                    frequency = maxFrequency;
                    Console.WriteLine("Too big frequency!");
                }

                else if (value < frequency)
                {
                    frequency = minFrequency;
                    Console.WriteLine("Too low frequency!");
                }

                else
                {
                    frequency = value;
                }
            }
        }

                public void On()
        {
            IsOn = true;
            Console.WriteLine("Radio is on!");
        }

        //turn radio off
        public void Off()
        {
            IsOff = true;
            Console.WriteLine("Radio is now off!");
        }

        public void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("Radio information:");
            Console.WriteLine(" Radio is on: " + IsOn);
            Console.WriteLine(" Volume: " + Volume);
            Console.WriteLine(" Frequency is :" + Frequency);
            Console.WriteLine(" Radio is off: " + IsOff);
        }
    }
 }
    
