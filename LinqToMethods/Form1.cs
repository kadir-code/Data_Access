using LinqToMethods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        private void btnExacute_Click(object sender, EventArgs e)
        {
            //tolist()
            dataGridView1.DataSource = db.Products
                .ToList();

            //where
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .ToList();

            //orderby()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .OrderBy(x => x.ProductID)
                .ToList();

            //thenby()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .OrderBy(x => x.ProductID)
                .ThenBy(x => x.UnitsInStock)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

            //groupby()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 50).OrderBy(x => x.ProductID).ThenBy(x => x.UnitsInStock).ThenByDescending(x => x.UnitPrice).GroupBy(x => x.Category.CategoryName).ToList();

            //tolookup()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 50).OrderBy(x => x.ProductID).ThenBy(x => x.UnitsInStock).ThenByDescending(x => x.UnitPrice).ToLookup(x => x.Category.CategoryName).ToList();

            //select()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .Select(x => 
                new 
                { 
                    x.ProductID,
                    x.ProductName, 
                    x.UnitPrice, 
                    x.Category, 
                    x.UnitsInStock 
                }).OrderBy(x => x.ProductID)
                .ThenBy(x => x.UnitsInStock)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

            //all()
            bool isTrue = db.Products.All(x => x.UnitsInStock >= 50);
            switch (isTrue)
            {
                case false:
                    MessageBox.Show("Not All Elements >= 50");
                    break;
                default:
                    MessageBox.Show("All Elements >= 50");

                    break;
            }

            //any()
            bool isTrue1 = db.Products.Any(x => x.UnitsInStock >= 50);
            switch (isTrue1)
            {
                case false:
                    MessageBox.Show("Not All Elements >= 50");
                    break;
                default:
                    MessageBox.Show("At Least One Element >= 50");

                    break;
            }

            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50 && x.ProductName.Contains("a"))
                .Select(x => 
                new { 
                    x.ProductID, 
                    x.ProductName, 
                    x.UnitPrice, 
                    x.Category, 
                    x.UnitsInStock }).ToList();


            //Performs a custom aggregation operation on the values in the collection.
            List<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var customAggregate = strList.Aggregate((s1, s2) => s1 + "<=> " + s2);

            MessageBox.Show(customAggregate);

            //average
            decimal? average = db.Products.Average(x => x.UnitPrice);

            MessageBox.Show($"Average Of UnitPrice: {average.ToString()}");

            //count()
            var productCount = db.Products.
                Where(x => x.ProductName.Contains("a"))
                .Count(x => x.UnitPrice < 25);

            MessageBox.Show($"Count Of Products :{productCount}");

            //min()
            var min = db.Products.Min(x => x.UnitPrice);

            MessageBox.Show($"Min Of Products :{min}");

            //max()
            var max = db.Products.Max(x => x.UnitPrice);

            MessageBox.Show($"Max Of Products :{max}");

            //sum()
            var sum = db.Products.Sum(x => x.UnitsInStock);

            MessageBox.Show(sum.ToString());

            //first()
            Category category = db.Categories.First(x => x.CategoryName == "SeaFood");

            MessageBox.Show($"{category.CategoryName}");

            //firstordefault does not throws exception
            Category categoryy = db.Categories.FirstOrDefault(x => x.CategoryID == 1);

            MessageBox.Show($"{categoryy.CategoryName}");
        }
    }
}
