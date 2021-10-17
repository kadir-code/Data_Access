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

        public void CreateItem(Genre item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Genre item)
        {
            throw new NotImplementedException();
        }

        public Genre FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Genre GetByDefault(Expression<Func<Genre, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetByDefaults(Expression<Func<Genre, bool>> exp)
        {
            return db.Query<Genre>("select * from genre").ToList();
        }

        public List<Genre> ListActiveItems()
        {
            throw new NotImplementedException();
        }

        public void ListAllItems(DataGridView dataGridView)
        {
            List<Genre> genres=db.Query<Genre>("up_GetAllGenres",commandType:CommandType.StoredProcedure).ToList();
            dataGridView.DataSource = genres;
            
        }

        public void UpdateItem(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
