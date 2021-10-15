using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD.Context
{
    public class DataContext
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    }
}
