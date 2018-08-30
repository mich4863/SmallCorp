using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallCorp.Entities;

namespace SmallCorp.DataAccessBase
{
    public static class Convert
    {
        public static Employee ToEmployee(DataRow dataRow)
        {
            string firstname = (string)dataRow["Firstname"];
            string lastname = (string)dataRow["Lastname"];
            string position = (string)dataRow["Position"];
            decimal salary = (decimal)dataRow["Salary"];
            DateTime startDate = (DateTime)dataRow["StartDate"];

            return new Employee(firstname, lastname, position, salary, startDate);
        }
    }
}
