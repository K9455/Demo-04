using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulkuneuvoApplication
{
    class Bike: kulkuneuvo
    {
        // constructor/luokan alustaja/alustajat
        // oletusconstructor, aina julkinen, luokan nimi
        public bool GearWheels { get; set; }
        public string GearWheelsName { get; set; }

        public Bike()
        {
        }

        public Bike(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // toiminnot, methods -> mitä olio osaa tehdä
        public void BikeMethod()
        {
            Console.WriteLine("This method belongs to Bike!");
        }

        // override ylikirjoittaa

        public override string ToString()
        {
            return base.ToString() + " " + "GearWheels:" + GearWheels + "Gearwheelsname:" + GearWheelsName;
        }
    }
}
