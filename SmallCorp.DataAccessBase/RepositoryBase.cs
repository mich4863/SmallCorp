using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCorp.DataAccessBase
{
    public abstract class RepositoryBase
    {
        // Field
        private readonly string connectionString;

        // Constructor
        public RepositoryBase(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method Execute, return a dataSet from DB.
        protected virtual DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            try
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
                {
                    adapter.Fill(resultSet);
                }
            }
            catch(Exception e)
            {
                throw new DataAccessException("Error accessing data", e);
            }
            return resultSet;
        }
    }
}
