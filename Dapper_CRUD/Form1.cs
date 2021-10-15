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
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            repository.CreateStudent(txtCreateStudent);
        }
    }
}
