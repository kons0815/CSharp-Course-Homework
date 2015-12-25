using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SalaryReport report = new SalaryReport();
            report.Employees = new Employee[]{
                new Manager() { BaseSalary = 50000, Benifit = 20000, Level = 5, Name = "ABC"},
                new Manager() { BaseSalary = 40000, Benifit = 10000, Level = 4, Name = "DEF"},
                new ProductManager(){ BaseSalary = 30000, Level = 3, Name="PM"},
                new Sales(){BaseSalary = 26000, Level = 2, Name="超級銷售員", partment= "電玩銷售部" ,saleQuanity =5000},
                new PartBoss(){BaseSalary = 32000, Level = 3, Name="部門組長", partment= "電玩銷售部" ,saleQuanity = 10000},
                new PartTime(){BaseSalary = 24000, Level = 1, Name="熱血工讀生", partment= "電玩銷售部",saleQuanity = 2000},
                new Sales(){BaseSalary = 24000, Level = 2, Name="懶惰銷售員", partment= "小吃飯賣部",saleQuanity = 3000},
                new PartBoss(){BaseSalary = 30000, Level = 3, Name="小吃組長", partment= "小吃飯賣部",saleQuanity = 0},
                new PartTime(){BaseSalary = 22000, Level = 1, Name="大胃王工讀生", partment= "小吃飯賣部",saleQuanity = 200},
            };

            report.Print();
        }
    }
}