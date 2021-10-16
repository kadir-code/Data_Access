using Dapper;
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

namespace Dapper_PhoneDiary
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection("Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=DapperCrudDb;Trusted_Connection=True");

        int contactId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void GetAllContacts()
        {
            List<Contact> contacts = db.Query<Contact>("up_GetAllContact", commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = contacts;
        }
        void Eraser(TextBox txtName,TextBox txtNumber)
        {
            txtName.Text = String.Empty;
            txtNumber.Text = String.Empty;
            btnSave.Text = "Save";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (db.State==ConnectionState.Closed)
            {
                db.Open();

                //the parameters of stored procedure and ones inside param have to be same
                DynamicParameters param = new DynamicParameters();
                param.Add("@contactid", contactId);
                param.Add("@name", txtName.Text.Trim());
                param.Add("number",txtNumber.Text.Trim());
                db.Execute("up_ContactAddOrEdit",param,commandType:CommandType.StoredProcedure);

                if (contactId==0)
                {
                    MessageBox.Show("Saved Succesfully");

                }
                else
                {
                    MessageBox.Show("Updated Succesfully");

                }
                GetAllContacts();
                Eraser(txtName, txtNumber);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllContacts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Eraser(txtName,txtNumber);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btnSave.Text = "Edit";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@contactid",contactId);
            db.Execute("up_ContactAddOrEdit",param,commandType:CommandType.StoredProcedure);
            Eraser(txtName,txtNumber);
            GetAllContacts();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
