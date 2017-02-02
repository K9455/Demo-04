using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            int luku = 0;
  
            do {
                Console.WriteLine("Valitse kerros väliltä 1-5: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                hissi.Floor = luku;
                Console.WriteLine("Hissi on nyt kerroksessa " + hissi.Floor);

                } while (luku != 0);
            } 
        }
    }


