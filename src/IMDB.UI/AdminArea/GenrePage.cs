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
namespace IMDB.UI.AdminArea
{
    public partial class GenrePage : Form
    {
       SqlConnection db = new SqlConnection("Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=DapperIMDB;Trusted_Connection=True");
        GenreRepository genreRepository = new GenreRepository();
        public GenrePage()
        {
            InitializeComponent();
        }

        private void GenrePage_Load(object sender, EventArgs e)
        {
            //Genre genre = new Genre();
            List<Genre> genres=db.Query<Genre>("up_GetAllGenres", commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = genres;
            //genreRepository.ListAllItems(dataGridView1);
        }
    }
}
