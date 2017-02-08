using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulkuneuvoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Color = "Blue";
            bike.ModelYear = 2000;
            bike.GearWheels = true;
            bike.GearWheelsName = "Shimano";
            Console.WriteLine("Bike info:");
            Console.WriteLine(bike.ToString());
            Console.WriteLine();

            Bike bike2 = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Color = "Green";
            bike.ModelYear = 2000;
            bike.GearWheels = false;
            bike.GearWheelsName = " ";
            Console.WriteLine("Bike info:");
            Console.WriteLine(bike.ToString());
            Console.WriteLine();

            Boat boat = new Boat();
            boat.Name = "Meri";
            boat.Model = "S800";
            boat.Color = "Green";
            boat.ModelYear = 2010;
            boat.SeatCount = 5;
            boat.BoatType = "Motorboat";
            Console.WriteLine("Boat info:");
            Console.WriteLine(boat.ToString());
            Console.WriteLine();

            Boat boat2 = new Boat();
            boat.Name = "Anna";
            boat.Model = "S600";
            boat.Color = "Red";
            boat.ModelYear = 2010;
            boat.SeatCount = 5;
            boat.BoatType = "Motorboat";
            Console.WriteLine("Boat info:");
            Console.WriteLine(boat.ToString());
            Console.WriteLine();
        }
    }
}
