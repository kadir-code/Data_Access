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
        void CreateItem(T item,TextBox textBox);
        void UpdateItem(T item,TextBox textBox,TextBox textBox1);
        void DeleteItem(T item,TextBox textBox);
        T FindById(int id,TextBox textBox);
    }
}
