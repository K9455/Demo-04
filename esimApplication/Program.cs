using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one teacher from teacher class

            Teacher teacher = new Teacher();
            teacher.Firstname = "Kaisa";
            teacher.Lastname = "Kakkanen";
            teacher.Address = "Kakkatie 6";
            teacher.Age = 55;
            teacher.PhoneNumber = "444-666";
            teacher.Room = "A222";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Mallikas", "H9900");
            student.Address = "Kirkkotie 5";
            student.Age = 12;
            student.PhoneNumber = "77777777";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
