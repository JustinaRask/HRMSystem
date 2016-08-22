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
        public string BirthDateFromID { get; set; }


        public void CalculateNetSalary()
        {
          NetSalary = GrossSalary * 0.76;
        }

        public void GetBirthDateFromID()
        {
            string PersonIDString = PersonID.ToString();
            int Year = Convert.ToInt32(PersonIDString.Substring(1, 2));
            int Month = Convert.ToInt32(PersonIDString.Substring(3, 2));
            int Day = Convert.ToInt32(PersonIDString.Substring(5, 2));
            DateTime BirthDateFromID = new DateTime(Year, Month, Day);

        }
    }
}
