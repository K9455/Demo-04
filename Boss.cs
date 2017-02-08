using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3application
{
    class Boss: Person
    { 
        public string Car { get; set; }
        

        public Boss()
        {
        }

        public Boss(string firstname, string lastname,string car)
            : base(firstname, lastname)
        { 

            Car = car;  // isolla kirjaimella:ominaisuudet, pienet: parametrejä
        }

        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss!");
        }

        public override string ToString()
    {
            return base.ToString() + " " + "car:" + Car;
    }

   }
  }

