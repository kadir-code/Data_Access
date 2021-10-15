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
        //public void GetAllStudents(DataGridView datagridview)
        //{
        //    using (IDbConnection connection = new SqlConnection("Server = DESKTOP - J1PKMI5\\SQLEXPRESS; Database=DpFirstConsoleDB;Trusted_Connection=True;"))
        //    {
        //        connection.Open();
        //        var name = connection.Query<Student>("select * from students");
        //        foreach (var item in name)
        //        {

        //            datagridview.DataSource= (item.StudentId + " ---------------------" + item.FirstName);
        //        }
        //        connection.Close();
        //    }
        //}


    }
}
#region metot
//public void GetAllStudents(DataGridView datagridview)
//{
//    using (IDbConnection connection = new SqlConnection("Server = DESKTOP - J1PKMI5\\SQLEXPRESS; Database=DpFirstConsoleDB;Trusted_Connection=True;"))
//    {
//        connection.Open();
//        List<Student> students = connection.Query<Student>("select studentname from students").ToList();
//        connection.Close();
//    }
//}
#endregion
#region
//    IDbConnection db = new SqlConnection("Server = DESKTOP - J1PKMI5\\SQLEXPRESS; Database=DpFirstConsoleDB;Trusted_Connection=True")
//    {

//    }

//    public void CreateStudent(TextBox textBox)
//    {
//        db.Execute("insert into students values(@name)",
//            new
//            {
//                name = textBox.Text
//            });
//    }

//    //public List<Student> GetAllStudents(Student student)
//    //{
//    //    throw new NotImplementedException();
//    //    // return db.Execute("up_GetAllStudents", commandType: CommandType.StoredProcedure);
//    //    //return db.Query("select studentname from students").ToList();
//    //}
#endregion
