using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3application
{
    class Employee : Person
    {
        
        // constructor/luokan alustaja/alustajat
        // oletusconstructor, aina julkinen, luokan nimi

        public Employee()
        {
        }

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to Employee!");
        }
        // toiminnot, methods -> mitä olio osaa tehdä
        // override ylikirjoittaa

        public override string ToString()
        {
            return "Name:" + Firstname + " " + Lastname + " Profession:" + Profession + " Salary:" + Salary;
        }
    }
}
