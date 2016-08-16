using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrmSystem
{
   public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long PersonID { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double FTE { get; set; }
        public string StartDate { get; set; }
        public double GrossSalary { get; set; }
        public string Manager { get; set; }
        public double NetSalary { get; set; }

        public void CalculateNetSalary()
        {
          NetSalary = GrossSalary * 0.76;
        }
    }
}
