/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class fourth
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rikin Tuladhar");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the numbers");
                int val = Int32.Parse(Console.ReadLine());
                numbers[i] = val;
                
            }
            int initial = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                if(initial < numbers[i])
                {
                    initial = numbers[i];
                }
                
            }
            Console.WriteLine("The greatest number is: "+ initial);
        }
    }
}
*/