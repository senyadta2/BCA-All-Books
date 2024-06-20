/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        public int id;
        public string name;
        public double marks;
        public string address;
        public Student(int id, string name, double marks, string address) {
            this.id = id;
            this.name = name;
            this.marks = marks;
            this.address = address;
        }
    }
    internal class second
    {   
        public static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
            new Student(1,"Ravi",2.6,"kathmandu"),
            new Student(2, "Sita", 3, "patan"),
            new Student(3, "Hari", 2.3, "bhaktapur"),
            new Student(4, "Suman", 2.7, "kathmandu"),
            new Student(5, "Hari", 2.3, "bhaktapur")
            };
            var result = list.Where(s => s.address == "kathmandu" && s.marks >= 2.5).Select(s => new{s.name,s.address,s.marks });
            Console.WriteLine("Rikin Tuladhar");
            Console.WriteLine("Name of the students whose address is kathmandu and Mark is greater than 2.5");

            foreach(var student in result)
            {
                Console.WriteLine($"Name: {student.name}||Address:{student.address}||Mark:{student.marks} ");
            }

        }


    }
}
*/