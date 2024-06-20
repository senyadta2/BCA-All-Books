/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class indexerEg
    {
        private string[] valueArray = new string[3];
        public string this[int index]
        {
            get { return valueArray[index]; }
            set { valueArray[index] = value; }
        }
    }
    

    internal class fifth
    {
        public static void Main(string[] args)
        {
            indexerEg obj = new indexerEg();
            obj[0] = "Hello";
            obj[1] = "World";
            obj[2] = "!";
            Console.WriteLine("Rikin Tuladhar");
            Console.WriteLine("The result is {0} {1} {2}", obj[0], obj[1], obj[2]);
        }
    }
}
*/