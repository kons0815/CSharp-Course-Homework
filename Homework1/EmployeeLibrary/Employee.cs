using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee : IComparable<Employee>
    {
        public string Name { get; set; }

        public int Level { get; set; }

        private int baseSalary;

        public int BaseSalary
        {
            get { return this.baseSalary; }
            set
            {
                if (value < 22000)
                    this.baseSalary = 22000;
                else if (value > 50000)
                    this.baseSalary = 50000;
                else
                    this.baseSalary = value;
            }
        }

        virtual public int Salary
        {
            get { return this.baseSalary; }
        }

        public int CompareTo(Employee other)
        {
            return this.Level - other.Level;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("姓名:{0}\n", this.Name);
            result += string.Format("職等:{0}\n", this.Level);
            result += string.Format("薪資:{0}\n", this.Salary);
            return result;
        }
    }
}