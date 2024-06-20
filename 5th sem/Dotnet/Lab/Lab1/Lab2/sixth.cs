/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public void Deconstruct(out string name,out string address)
        {
            name = Name;
            address = Address;
        }
    }
    internal class sixth
    {
        public static void Main(string[] args)
        {
            person obj = new person("Ravi", "Tahacal");
            var (name, address) = obj;
            Console.WriteLine("Rikin Tuladhar");    
            Console.WriteLine($"Name is {name} and address is {address}");
        }
    }
}
*/