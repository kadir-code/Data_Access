using E_CommercialDb.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialDb.Models.Entities.Concrete
{
    public class Shipper: BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }

    }
}
