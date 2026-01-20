using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class DatabaseManager
    {

        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
