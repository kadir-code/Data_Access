using IMDB.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Models.Entities.Concrete
{
    public class AssignedMovieToDirektor : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
