using LinqToSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQL
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            //var employees = from x in db.Employees
            //                select new
            //                {
            //                    x.FirstName,
            //                    x.LastName,
            //                    x.Title,
            //                    x.BirthDate
            //                };
            //dataGridView1.DataSource = employees.ToList();

            //var employees = from x in db.Employees
            //                where x.EmployeeID >= 2 && x.EmployeeID <= 8
            //                orderby x.FirstName
            //                select new
            //                {
            //                    x.FirstName,
            //                    x.LastName,
            //                    x.Title,
            //                    x.BirthDate
            //                };

            //dataGridView1.DataSource = employees.ToList();


            //var result = from emp in db.Employees
            //             where SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) > 60
            //             orderby SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) descending
            //             select new
            //             {
            //                 Adı = emp.FirstName,
            //                 Soyadı = emp.LastName,
            //                 Yas = SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now)
            //             };
            //dataGridView1.DataSource = result.ToList();

            //var result = from emp in db.Employees
            //             where emp.TitleOfCourtesy == "Mr." && SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) > 60
            //             select new
            //             {
            //                 Adı = emp.FirstName,
            //                 Soyadı = emp.LastName,
            //                 Title = emp.TitleOfCourtesy,
            //                 Yas = SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now)
            //             };

            //dataGridView1.DataSource = result.ToList();



            //var result = from od in db.Order_Details
            //             orderby od.Quantity * od.UnitPrice * (int)Math.Floor(1 - od.Discount)
            //             group od by od.OrderID into kyw
            //             select new
            //             {
            //                 OrderId = kyw.Key,
            //                 Total = kyw.Sum(x=> x.Quantity * x.UnitPrice * (int)Math.Floor(1- x.Discount))
            //             };

            //dataGridView1.DataSource = result.ToList();



            //dataGridView1.DataSource = db.Categories
            //    .Join(db.Products, c => c.CategoryID, p => p.CategoryID, (c, p) => new { c, p })
            //    .GroupBy(x => x.c.CategoryName)
            //    .Select(x => new
            //    {
            //        CategoryName= x.Key,
            //        Count = x.Sum(z=> z.p.UnitsInStock)
            //    })
            //    .OrderByDescending(x=> x.Count)
            //    .ToList();

            //dataGridView1.DataSource =
            //    db.Products.Join(db.Order_Details, p => p.ProductID, od => od.ProductID, (p, od) => new { p, od })
            //               .GroupBy(x => x.p.ProductName)
            //               .Select(x => new
            //               {
            //                   UrunAdi = x.Key,
            //                   Miktar = x.Sum(z => z.od.Quantity),
            //                   Gelir = x.Sum(z => z.od.Quantity * z.od.UnitPrice * (int)Math.Floor(1 - z.od.Discount))
            //               })
            //               .OrderByDescending(x => x.Gelir)
            //               .ToList();

            dataGridView1.DataSource =
            db.Employees.Join(db.Orders, emp => emp.EmployeeID, o => o.EmployeeID, (emp, o) => new { emp, o })
                      .Join(db.Order_Details, ord => ord.o.OrderID, od => od.OrderID, (ord, od) => new { ord, od })
                      .GroupBy(x => x.ord.emp.FirstName)
                      .Select(x => new
                      {
                          Calisan = x.Key,
                          Toplam = x.Sum(z => z.od.Quantity * z.od.UnitPrice * (int)Math.Floor(1 - z.od.Discount))
                      })
                      .OrderByDescending(x => x.Toplam)
                      .ToList();
        }
    }
}
