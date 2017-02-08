using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulkuneuvoApplication
{
    class Boat: kulkuneuvo
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {
        }

        public Boat(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // toiminnot, methods -> mitä olio osaa tehdä
        public void BoatMethod()
        {
            Console.WriteLine("This method belongs to Boat!");
        }

        // override ylikirjoittaa

        public override string ToString()
        {
            return base.ToString() + " " + "SeatCount: " + SeatCount + "BoatType: " + BoatType;
        }
    }
}

