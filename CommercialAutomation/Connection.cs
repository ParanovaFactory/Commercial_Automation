using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommercialAutomation
{
    public class Connection
    {
        public SqlConnection connection() 
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=Db_CommercialAutomation;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            return conn;
        }
    }
}
