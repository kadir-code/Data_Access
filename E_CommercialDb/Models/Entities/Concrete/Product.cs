using E_CommercialDb.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialDb.Models.Entities.Concrete
{
    public class Product:BaseEntity
    {

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
