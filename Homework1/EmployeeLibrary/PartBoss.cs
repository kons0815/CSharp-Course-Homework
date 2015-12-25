using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class PartBoss : Employee
    {
        public string partment;
        public int saleQuanity;
        public override string ToString()
        {
            string result = base.ToString();
            //result += string.Format("底薪:{0}\n", this.BaseSalary);
            result += string.Format("部門:{0}\n", this.partment);
            result += string.Format("銷售業績:{0}\n", this.saleQuanity);
            return result;
        }
    }
}
