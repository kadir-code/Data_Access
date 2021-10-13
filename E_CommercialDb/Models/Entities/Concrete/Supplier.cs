using E_CommercialDb.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialDb.Models.Entities.Concrete
{
    public class Supplier:BaseEntity
    {
        public virtual List<Product> Products { get; set; }

    }
}
