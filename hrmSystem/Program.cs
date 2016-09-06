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
            //Employee[] employeeArray = new Employee[100]; - //cia kaip array apsibrezia 


            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee();
            
            employee1.Name = "Giedrius";
            employee1.Surname = "Giedraitis";
            employee1.PersonID = 48505170052;
            employee1.Age = 25;
            employee1.FTE = 0.5;
            employee1.StartDate = new DateTime(2014,8,19);
            employee1.Manager = "Kovas Kovaitis";
            employee1.GrossSalary = 1000.50;
            employee1.EmployeeAddress = new Address()
            {
                Country = "Lithuania",
                City = "Vilnius",
                Street = "Kalvarijų",
                HouseNumber = 15,
                HouseNumberLetter = 'B',
                FlatNumber = 4,
                PostCode = "LT-45621",
            };
            employees.Add(employee1);
            


            //employeeArray[0] = employee1; //cia taip is array iskvieciama. siuo atveju geriau naudoti lista. 
         
            Employee employee2 = new Employee();
            employee2.Name = "Vaida";
            employee2.Surname = "Vaidaite";
            employee2.PersonID = 48305170052;
            employee2.Age = 26;
            employee2.FTE = 1;
            employee2.StartDate = new DateTime(2014,5,6);
            employee2.Manager = "Petras Petraitis";
            employee2.GrossSalary = 1500;
            employee2.EmployeeAddress = new Address()
             {
                 Country = "Lithuania",
                 City = "Vilnius",
                 Street = "Kalvarijų",
                 HouseNumber = 15,
                 HouseNumberLetter = 'B',
                 FlatNumber = 4,
                 PostCode = "LT-45621",
             };
            employees.Add(employee2);

          
            Employee employee3 = new Employee();
            employee3.Name = "Vaida";
            employee3.Surname = "Vaidaitiene";
            employee3.PersonID = 47305170052;
            employee3.Age = 27;
            employee3.FTE = 1;
            employee3.StartDate = new DateTime(2013,5,6);
            employee3.Manager = "Petras Petraitis";
            employee3.GrossSalary = 1500;
            employee3.EmployeeAddress = new Address()
             {
                 Country = "Lithuania",
                 City = "Vilnius",
                 Street = "Kalvarijų",
                 HouseNumber = 15,
                 HouseNumberLetter = 'B',
                 FlatNumber = 4,
                 PostCode = "LT-45621",
             };
            employees.Add(employee3);
           
            Employee employee4 = new Employee();
            employee4.Name = "Rima";
            employee4.Surname = "Rimaitiene";
            employee4.PersonID = 48608170052;
            employee4.Age = 27;
            employee4.FTE = 1;
            employee4.StartDate = new DateTime(2013,5,6);
            employee4.Manager = "Petras Petraitis";
            employee4.GrossSalary = 1500;
            employee4.EmployeeAddress = new Address()
             {
                 Country = "Lithuania",
                 City = "Vilnius",
                 Street = "Kalvarijų",
                 HouseNumber = 15,
                 HouseNumberLetter = 'B',
                 FlatNumber = 4,
                 PostCode = "LT-45621",
             };
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.Name = "Indre";
            employee5.Surname = "Indraitiene";
            employee5.PersonID = 48608170052;
            employee5.Age = 27;
            employee5.FTE = 1;
            employee5.StartDate = new DateTime(2015, 4, 1);
            employee5.Manager = "Petras Petraitis";
            employee5.GrossSalary = 1500;
            employee5.EmployeeAddress = new Address()
             {
                 Country = "Lithuania",
                 City = "Vilnius",
                 Street = "Guobu",
                 HouseNumber = 15,
                 HouseNumberLetter = 'B',
                 FlatNumber = 4,
                 PostCode = "LT-45621",
             };
            employees.Add(employee5);

            DateTime fromDate = new DateTime(2014, 5, 6);
            DateTime toDate = new DateTime(2015, 5, 6);
            List<Employee> employeesByRange = GetEmployeesByDataRange(fromDate, toDate, employees);
            ShowAllEmployeesInConsole(employeesByRange);
            
            //ShowAllEmployeesInConsole(employees);
            //List<Employee> managersEmployees = GetEmployeesOfManager("Kovas Kovaitis", employees);
            //ShowAllEmployeesInConsole(managersEmployees);

            

            Console.ReadLine();
        }

        static void ShowAllEmployeesInConsole(List<Employee> employees) // void metodas nieko negrazina, jokio rezultato, arba grazina viska - visus darbutojus 
        {
            foreach (var employee in employees) // foreach naudoti kai yra list'as, kai yra masyvas - naudoti for cikla. 
            {
                Console.WriteLine("Employee added: Name: {0}, Surname: {1}, Person ID: {2}, Age: {3}, FTE: {4}, Start date: {5}, Manager: {6}, Gross Salary: {7}, Net Salary: {8}, Address: {9} Birth Date {10}",
                    employee.Name, employee.Surname, employee.PersonID, employee.Age, employee.FTE, employee.StartDate, employee.Manager, employee.GrossSalary, employee.CalculateNetSalary(), employee.EmployeeAddress.ToString(), employee.GetBirthDateFromID());
                Console.WriteLine("----------------------------");
                //employee.NetSalary, employee.BirthDateFromID);
            }
        }


        
        static List<Employee> GetEmployeesOfManager(string manager, List<Employee> employees) // jei norim kazkokio rezultato, tada vietoj voido turim apsirasyti tipa, parametra, kuri grazinsim is tos funkcijos, 
        {
            List<Employee> currentManagerEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (manager == employee.Manager)
                {
                    currentManagerEmployees.Add(employee);
                }
            }
            return currentManagerEmployees;
        }

        static List<Employee> GetEmployeesByDataRange(DateTime fromDate, DateTime toDate, List<Employee> employees)
        {
            List<Employee> currentDateRangeEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.StartDate >= fromDate && employee.StartDate <= toDate)
                {
                    currentDateRangeEmployees.Add(employee);
                }
            }
            return currentDateRangeEmployees;
        }
        
    }
}

       
  
 

