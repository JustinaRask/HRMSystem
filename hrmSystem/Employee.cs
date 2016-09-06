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
        public double FTE { get; set; }
        public DateTime StartDate { get; set; }
        public double GrossSalary { get; set; }
        public string Manager { get; set; }
        public Address EmployeeAddress { get; set; }
        public string BirthDateFromID { get; set; }

        public double CalculateNetSalary()
        {
         return GrossSalary * 0.76;
        }
        
        public DateTime GetBirthDateFromID()
        {
            int FinalYear = 0;
            string PersonIDString = PersonID.ToString();
    
            int Century = Convert.ToInt32(PersonIDString.Substring(0, 1));
            int Year = Convert.ToInt32(PersonIDString.Substring(1, 2));
            int Month = Convert.ToInt32(PersonIDString.Substring(3, 2));
            int Day = Convert.ToInt32(PersonIDString.Substring(5, 2));
            if (Century > 4)
            {
                FinalYear = 2000 + Year;
            }
            else if (Century <=4)
            {
                FinalYear = 1900 + Year;
            }
            DateTime BirthDateFromID = new DateTime(FinalYear, Month, Day);
            return BirthDateFromID;
        }
        
    }
}
