/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface Student
    {
        public void studentId();

    }
    interface Employee
    {
        public void employeeId();   
    }
    internal class multipleeg : Student,Employee
    {
        public void employeeId()
        {
            Console.WriteLine("The employee Id");
        }
        public void studentId()
        {
            Console.WriteLine("This student Id");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Rikin Tuladhar");
            multipleeg obj = new multipleeg();
            obj.employeeId();
            obj.studentId();
            
        }

    }
}
*/