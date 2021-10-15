using Dapper;
using Dapper_CRUD.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD.Repositories.Concrete
{
    public class Repository 
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public void CreateStudent(TextBox textBox)
        {
            db.Execute("insert into students values(@name)",
                new
                {
                    name = textBox.Text
                });
        }
        public List<Student> GetAllStudents(Student student)
        {
            throw new NotImplementedException();
            // return db.Execute("up_GetAllStudents", commandType: CommandType.StoredProcedure);
            //return db.Query("select studentname from students").ToList();
        }

     
    }
}
