using Dapper;
using IMDB.Infrasutructure.Repositories.Interfaces;
using IMDB.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace IMDB.Infrasutructure.Repositories.Concrete
{
    //this genre come from imdb.models layer
    public class GenreRepository:IBaseRepository<Genre>
    {
        SqlConnection db;
        public GenreRepository()
        {
            db = new SqlConnection("Server=DESKTOP-J1PKMI5\\SQLEXPRESS;Database=DapperIMDB;Trusted_Connection=True");
        }

        public void CreateItem(Genre item,TextBox textBox)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@name",textBox.Text.Trim());
            db.Execute("up_InsertGenre",param,commandType:CommandType.StoredProcedure);
        }

        public void DeleteItem(Genre item,TextBox textBox)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id",Convert.ToInt32(textBox.Text));
            db.Query("up_DeleteGenre",param,commandType:CommandType.StoredProcedure);


        }

        public Genre FindById(int id,TextBox textBox)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id",textBox.Text);
            Genre genre = db.QueryFirstOrDefault<Genre>("up_GetGenreById",param,commandType:CommandType.StoredProcedure);
            return genre;
        }

        public List<Genre> ListActiveItems()
        {

            List<Genre> genres = db.Query<Genre>("up_GetAllGenres", commandType: CommandType.StoredProcedure)
                .Where(x => x.Status != Models.Entities.Enum.Status.Passive)
                .ToList();

            return genres;
        }

        public void ListAllItems(DataGridView dataGridView)
        {
            List<Genre> genres=db.Query<Genre>("up_GetAllGenres",commandType:CommandType.StoredProcedure).ToList();
            dataGridView.DataSource = genres;
            
        }

        public void UpdateItem(Genre item,TextBox textBoxId,TextBox textBoxName)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id",textBoxId.Text.ToString());
            param.Add("@name",textBoxName.Text);
            item.Status = Models.Entities.Enum.Status.Modified;
            item.UpadteDate = DateTime.Now;
            db.Execute("up_UpdateGenre",param,commandType:CommandType.StoredProcedure);
        }
    }
}
