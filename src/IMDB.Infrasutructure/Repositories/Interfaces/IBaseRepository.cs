using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB.Infrasutructure.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        void ListAllItems(DataGridView dataGridView);
        List<T> ListActiveItems();
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
        T FindById(int id);
        T GetByDefault(Expression<Func<T,bool>>exp);
        List<T> GetByDefaults(Expression<Func<T,bool>>exp);
    }
}
