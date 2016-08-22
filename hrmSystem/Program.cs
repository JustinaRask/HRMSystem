using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Giedrius";
            employee1.Surname = "Giedraitis";
            employee1.PersonID = 48505170052;
            employee1.Age = 25;
            employee1.Address = "Kalvariju 190-56";
            employee1.FTE = 0.5;
            employee1.StartDate = "2013-05-06";
            employee1.Manager = "Kovas Kovaitis";
            employee1.GrossSalary = 1000.50;
            employee1.CalculateNetSalary();
            //employee1.GetBirthDateFromID();
            //AddEmployeeToDatabase(employee1);
            //GetEmployeesOfPetrasPetraitis(employee1);
            //GetEmployeesStarted2013May16(employee1);


            Employee employee2 = new Employee();
            employee2.Name = "Vaida";
            employee2.Surname = "Vaidaite";
            employee2.PersonID = 48305170052;
            employee2.Age = 26;
            employee2.Address = "Kalvariju 1118-56";
            employee2.FTE = 1;
            employee2.StartDate = "2014-05-06";
            employee2.Manager = "Petras Petraitis";
            employee2.GrossSalary = 1500;
            employee2.CalculateNetSalary();
            //AddEmployeeToDatabase(employee2);
            //GetEmployeesOfPetrasPetraitis(employee2);
            GetEmployeesStarted2013May16(employee2);

            Employee employee3 = new Employee();
            employee3.Name = "Vaida";
            employee3.Surname = "Vaidaitiene";
            employee3.PersonID = 47305170052;
            employee3.Age = 27;
            employee3.Address = "Giedraiciu 1118-56";
            employee3.FTE = 1;
            employee3.StartDate = "2013-05-06";
            employee3.Manager = "Petras Petraitis";
            employee3.GrossSalary = 1500;
            employee3.CalculateNetSalary();
            //AddEmployeeToDatabase(employee3);
            //GetEmployeesOfPetrasPetraitis(employee3);
            GetEmployeesStarted2013May16(employee3);

            Employee employee4 = new Employee();
            employee4.Name = "Rima";
            employee4.Surname = "Rimaitiene";
            employee4.PersonID = 48608170052;
            employee4.Age = 27;
            employee4.Address = "Stoties-56";
            employee4.FTE = 1;
            employee4.StartDate = "2013-05-06";
            employee4.Manager = "Petras Petraitis";
            employee4.GrossSalary = 1500;
            employee4.CalculateNetSalary();
            //AddEmployeeToDatabase(employee3);
            //GetEmployeesOfPetrasPetraitis(employee3);
            GetEmployeesStarted2013May16(employee4);

            Employee employee5 = new Employee();
            employee5.Name = "Indre";
            employee5.Surname = "Indraitiene";
            employee5.PersonID = 48608170052;
            employee5.Age = 27;
            employee5.Address = "Stoties-56";
            employee5.FTE = 1;
            employee5.StartDate = "2013-05-06";
            employee5.Manager = "Petras Petraitis";
            employee5.GrossSalary = 1500;
            employee5.CalculateNetSalary();
            //AddEmployeeToDatabase(employee5);
            //GetEmployeesOfPetrasPetraitis(employee5);
            GetEmployeesStarted2013May16(employee5);

            Console.ReadLine();
        }

        static void AddEmployeeToDatabase(Employee employee)
        {
            Console.WriteLine("Employee added: Name: {0}, Surname: {1}, Person ID: {2}, Age: {3}, Address: {4}, FTE: {5}, Start date: {6}, Manager: {7}, Gross Salary: {8}, Net Salary: {9}, Birt Date from ID", employee.Name, employee.Surname, employee.PersonID, employee.Age, employee.Address, employee.FTE, employee.StartDate, employee.Manager, employee.GrossSalary, employee.NetSalary, employee.BirthDateFromID);
        }

        static void GetEmployeesOfPetrasPetraitis(Employee employee)
        {
            if (employee.Manager == "Petras Petraitis")
            {
                Console.WriteLine("Employee of Petras Petraitis added: Name: {0}, Surname: {1}, Person ID: {2}, Age: {3}, Address: {4}, FTE: {5}, Start date: {6}, Manager: {7}, Gross Salary: {8}, Net Salary: {9}", employee.Name, employee.Surname, employee.PersonID, employee.Age, employee.Address, employee.FTE, employee.StartDate, employee.Manager, employee.GrossSalary, employee.NetSalary);
            }
        }

        static void GetEmployeesStarted2013May16(Employee employee)
        {
            if (employee.StartDate == "2013-05-06")
            {
                Console.WriteLine("Employees who started on 2013 May 16 are added: Name: {0}, Surname: {1}, Person ID: {2}, Age: {3}, Address: {4}, FTE: {5}, Start date: {6}, Manager: {7}, Gross Salary: {8}, Net Salary: {9}", employee.Name, employee.Surname, employee.PersonID, employee.Age, employee.Address, employee.FTE, employee.StartDate, employee.Manager, employee.GrossSalary, employee.NetSalary);
            }
        }

    }
}

       
  
 

