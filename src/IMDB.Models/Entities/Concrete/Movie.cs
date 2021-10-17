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
    public class Movie : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        public string MovieName { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public List<AssignedMovieToGenre> AssignedMovieToGenres { get; set; }
        public List<AssignedMovieToDirektor> AssignedMovieToDirektors { get; set; }
    }
}
