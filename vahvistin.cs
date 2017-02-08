using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VahvistinApplication
{
    class vahvistin
    {
        // ominaisuudet
        private readonly int maxVolume = 100;
        private readonly int minVolume = 1;

        private int volume;
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
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                }

                else if (value < minVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                }

                else
                {
                    volume = value;
                }
            }
        }
    }
}
