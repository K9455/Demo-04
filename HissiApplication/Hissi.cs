using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Hissi
    {
        // ominaisuudet
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > maxFloor)
                {
                    Console.WriteLine("Kerros on liian iso!");
                }

                else if (value < minFloor)
                {
                    Console.WriteLine("Kerros on liian pieni!");
                }

                else
                {
                    floor = value;
                }
            }
        } 
    }
}
