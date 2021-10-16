using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace DapperOperations_Northwind
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection("Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExacute_Click(object sender, EventArgs e)
        {
            //update by execute
            //get list of employees by query
            db.Execute("update employees set firstname='jane' where employeeId=1");
            dataGridView1.DataSource = db.Query("select * from employees").ToList();

            //delete using execute
            db.Execute("delete from employees where employeeId=1");
            dataGridView1.DataSource = db.Query("select * from employees").ToList();

            //get top 5 elements
            dataGridView1.DataSource = db.Query("select top 5 * from categories").ToList();

            //strongly typed in case of having category class
            dataGridView1.DataSource = db.Query<Category>("select top 5 * from categories").ToList();

            //joined categories andproducts
            string sql = "select * from categories as c inner join products p on c.categoryId=p.categoryId";
            dataGridView1.DataSource = db.Query(sql).ToList();

            //get 10 most expensive products using stored procedure
            var sql = "[Ten Most Expensive Products]";
            dataGridView1.DataSource = db.Query(sql, commandType: CommandType.StoredProcedure).ToList();

            //get category bı user typed id from textbox using stored procedure
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", txtValue.Text.ToString());
            dataGridView1.DataSource = db.Query("sp_ProductByCategory", param, commandType: CommandType.StoredProcedure).ToList();

            //Write the sp that calculates how much shopping the customer, whose ID is given, has made in total
            DynamicParameters param = new DynamicParameters();
            param.Add("Id", txtValue.Text.ToString());
            dataGridView1.DataSource = db.Query("sp_GetCustomerOrders", param, commandType: CommandType.StoredProcedure).ToList();
        }

       
    }
}
