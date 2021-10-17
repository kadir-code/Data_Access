using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IMDB.Infrasutructure
{
    public static class Utilities
    {
       static void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
