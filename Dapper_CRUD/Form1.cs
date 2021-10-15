using Dapper;
using Dapper_CRUD.Entities.Concrete;
using Dapper_CRUD.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD
{
    public partial class Form1 : Form
    {
        public const string cs = "Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=DpFirstConsoleDB;Trusted_Connection=True";
        SqlConnection connection;
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection();




            var name = connection.Query<Student>("select * from students");
            foreach (var item in name)
            {

                listBox1.Items.Add(item.StudentId + "--" + item.FirstName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            //repository.GetAllStudents(dataGridView1);
        }
    }
}
