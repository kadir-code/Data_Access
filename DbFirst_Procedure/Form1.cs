using DbFirst_Procedure.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DbFirst_Procedure
{
    public partial class Form1 : Form
    {
        NorthwindEntities1 db;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindEntities1();
        }

      

        private void cmbCategory_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Category id = cmbCategory.SelectedItem as Category;
            if (id != null)
                dataGridView1.DataSource = db.sp_getCategoryById(id.CategoryID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            Category id = cmbCategory.SelectedItem as Category;
            if (id != null)
                dataGridView1.DataSource = db.sp_getCategoryById(id.CategoryID);
        }
    }
}
