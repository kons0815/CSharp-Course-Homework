using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class SalaryReport
    {
        public Employee[] Employees { get; set; }

        public void Print()
        {
            Array.Sort(this.Employees);
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}