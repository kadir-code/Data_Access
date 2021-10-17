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
    public class Genre : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public List<AssignedMovieToGenre> AssignedMovieToGenres { get; set; }
    }
}
