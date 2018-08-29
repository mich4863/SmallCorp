using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallCorp.Entities;

namespace SmallCorp.DataAccessBase
{
    public class EmployeeRepository : RepositoryBase
    {
        #region Constructor
        public EmployeeRepository()
            : base(ConnectionStrings.db) { }
        #endregion

        #region Method GetAllEmployees
        public virtual List<Employee> GetAllEmployees()
        {
            string sqlQuery = SqlQueries.selectAll + " Employees";

            DataSet employeeSet = base.Execute(sqlQuery);
            DataTable employeeTable = employeeSet.Tables[0];

            List<Employee> employees = new List<Employee>(0);

            foreach(DataRow employeeRow in employeeTable.Rows)
            {
                Employee em = Convert.ToEmployee(employeeRow);
                employees.Add(em);
            }
            return employees;
        } 
        #endregion
    }
}
