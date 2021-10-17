using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Infrasutructure.Context
{
    public class ApplicationDbContext
    {
       public SqlConnection db = new SqlConnection("Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=DapperIMDB;Trusted_Connection=True");
    }
}
