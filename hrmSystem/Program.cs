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
            employee1.StartDate = "2015-06-06";
            employee1.Manager = "Kovas Kovaitis";
            employee1.GrossSalary = 1000.50;
            employee1.CalculateNetSalary();           
            AddEmployeeToDatabase(employee1);

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
            AddEmployeeToDatabase(employee2);

            Console.ReadLine();
        }
        static void AddEmployeeToDatabase(Employee employee)
        {
            Console.WriteLine("Employee added: Name: {0}, Surname: {1}, Person ID: {2}, Age: {3}, Address: {4}, FTE: {5}, Start date: {6}, Manager: {7}, Gross Salary: {8}, Net Salary: {9}", employee.Name, employee.Surname, employee.PersonID, employee.Age, employee.Address, employee.FTE, employee.StartDate, employee.Manager, employee.GrossSalary, employee.NetSalary);
        }
        }
    }

