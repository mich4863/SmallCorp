using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallCorp.Entities;
using SmallCorp.DataAccessBase;

namespace SmallCorp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.GetAllEmployees();

            foreach(var item in employees)
            {
                Console.Write(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
