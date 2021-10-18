using IMDB.Infrasutructure.Repositories.Concrete;
using IMDB.Models.Entities.Concrete;
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
using IMDB.Infrasutructure;

namespace IMDB.UI.AdminArea
{
    public partial class GenrePage : Form
    {
        GenreRepository genreRepository = new GenreRepository();
        
        public GenrePage()
        {
            InitializeComponent();
        }

        private void GenrePage_Load(object sender, EventArgs e)
        {
            genreRepository.ListAllItems(dataGridView1);
        }

        private void btnOnlyActiveElements_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= genreRepository.ListActiveItems();
        }
        Genre genre = new Genre();
        private void btcCreateGenre_Click(object sender, EventArgs e)
        {

            genreRepository.CreateItem(genre,txtCreateGenre);
            dataGridView1.DataSource = genreRepository.ListActiveItems();
            Utilities.Eraser(grpCreateGenre);
        }

        private void BtnFindById_Click(object sender, EventArgs e)
        {
            genreRepository.FindById(genre.Id,txtFindById);
            dataGridView1.DataSource = genreRepository.ListActiveItems();
            Utilities.Eraser(grpCreateGenre);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateGenreId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUpdateGenre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Utilities.Eraser(grpCreateGenre);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            genreRepository.UpdateItem(genre,txtUpdateGenreId,txtUpdateGenre);
            dataGridView1.DataSource = genreRepository.ListActiveItems();
            Utilities.Eraser(grpCreateGenre);

        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            genreRepository.DeleteItem(genre,txtDeleteGenre);
            dataGridView1.DataSource= genreRepository.ListActiveItems();
            Utilities.Eraser(grpCreateGenre);

        }
    }
}
