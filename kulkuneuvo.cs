using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulkuneuvoApplication
{
    class kulkuneuvo
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }

        // constructor/luokan alustaja/alustajat
        // oletusconstructor, aina julkinen, luokan nimi

        public kulkuneuvo()
        {
        }

        public kulkuneuvo(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // toiminnot, methods -> mitä olio osaa tehdä
        public void kulkuneuvoMethod()
        {
            Console.WriteLine("This method belongs to kulkuneuvolle!");
        }

        // override ylikirjoittaa

        public override string ToString()
        {
            return "Name:" + Name + " " + "Model:" + Model + "Color:" + Color + "ModelYear:" + ModelYear;
        }
    }
}
