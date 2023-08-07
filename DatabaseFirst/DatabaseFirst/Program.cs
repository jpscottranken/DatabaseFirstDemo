using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Enter the line below now.
            var context = new EmployeeEntities();
            var Employee1 = new Employee()
            {
                EmployeeID = 1,
                FirstName = "Jeff",
                LastName = "Scott",
                Address = "751 Parr Rd.",
                City = "Wentzville",
                StateCode = "MO",
                Zip = "63385",
                Phone = "(214) 386-3675",
                DeptCode = 1,
                Salary = 67890
            };

            var Employee2 = new Employee()
            {
                EmployeeID = 2,
                FirstName = "Evan",
                LastName = "Gudmestad",
                Address = "4431 Finney Ave.",
                City = "St Louis",
                StateCode = "MO",
                Zip = "63113",
                Phone = "(214) 386-3991",
                DeptCode = 2,
                Salary = 78901
            };

            var Employee3 = new Employee()
            {
                EmployeeID = 3,
                FirstName = "Charles",
                LastName = "Corrigan",
                Address = "4431 Finney Ave.",
                City = "St Louis",
                StateCode = "MO",
                Zip = "63113",
                Phone = "(214) 386-4848",
                DeptCode = 3,
                Salary = 89012
            };

        context.Employees.Add(Employee1);
        context.Employees.Add(Employee2);
        context.Employees.Add(Employee3);

        context.SaveChanges();
        }
    }
}
