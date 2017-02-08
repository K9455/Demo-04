using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3application
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // constructor/luokan alustaja/alustajat
        // oletusconstructor, aina julkinen, luokan nimi

        public Person()
        {
        }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        // toiminnot, methods -> mitä olio osaa tehdä
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        // override ylikirjoittaa

        public override string ToString()
        {
            return "Name:" + Firstname + " " + Lastname + " Profession:" + Profession + " Salary:" + Salary;
        }
    }
}
