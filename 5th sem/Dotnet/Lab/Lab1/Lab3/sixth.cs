using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DepartmentEg
    {
        public string Department;
        public string Name;
        public int Salary;
        public DepartmentEg(string department,string name,int salary) {
            this.Department = department;
            this.Name = name;
            this.Salary = salary;
        }

    }
    internal class sixth
    {
        public  static void Main(string[] args) {

            List<DepartmentEg> list = new List<DepartmentEg>()
            {
                new DepartmentEg("sales","Ravi",20000),
                new DepartmentEg("product","Sita",2200),
                new DepartmentEg("sales","Suman",200000),
                new DepartmentEg("IT","Harry",40000),
                new DepartmentEg("sales","Gita",10000)
            };
            var result = list.Where(dep => dep.Department == "sales")
                .OrderByDescending(dep=>dep.Salary)
                .Select(dep=>dep.Salary)
                .FirstOrDefault();
            Console.WriteLine("Rikin Tuladhar");
            Console.WriteLine(result != null
     ? $"Highest salary in sales department: ${result}"
     : "No entries found in the sales department.");

        }

    }
}
