using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimApplication
{
    class Person
    {
        // fields (private)

        // ominaisuudet/properties

        public string Firstname { get; set; }
        public string Lastname { get; set;}
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

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
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
