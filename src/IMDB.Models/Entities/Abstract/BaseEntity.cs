using IMDB.Models.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Models.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get=>_createDate; set=>_createDate=value; }
        public DateTime? UpadteDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
