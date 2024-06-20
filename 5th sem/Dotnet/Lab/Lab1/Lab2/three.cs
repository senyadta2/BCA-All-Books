/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class three
    {
        private int value;
        public three(int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return value;
        }
        public static three operator +(three a, three b)
        {
            int result = a.value + b.value;
            return new three(result);
        }

    }
    class MainEg
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rikin Tuladhar");
            // Creating instances of CustomNumber
            three t1 = new three(1);
            three t2 = new three(1);

            // Using the overloaded + operator
            three result = t1 + t2;

            //displaying 
            Console.WriteLine("Value is :" +  result.getValue());
        }
    }
}
*/