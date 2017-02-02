using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimApplication
{
    class Teacher : Person
    {
        // ominaisuudet
        public string Room { get; set; }

        // constructors

        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;  // isolla kirjaimella:ominaisuudet, pienet: parametrejä
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            //base on tässätapauksessa Person-luokka eli kutsutaan Person-luokan toString() -metodi
            // return Firstname + " " .... + Room;
            
            return base.ToString() + " " + Room;
        }

    }
}
