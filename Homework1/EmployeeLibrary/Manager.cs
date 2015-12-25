using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int benifit;

        public int Benifit
        {
            get { return this.benifit; }
            set
            {
                if (value < 0)
                    this.benifit = 0;
                else if (value > 20000)
                    this.benifit = 20000;
                else
                    this.benifit = value;
            }
        }

        public override int Salary
        {
            get
            {
                return base.Salary + this.Benifit;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("底薪:{0}\n", this.BaseSalary);
            result += string.Format("獎金:{0}\n", this.Benifit);
            return result;
        }
    }
}