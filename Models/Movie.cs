using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Range(0, 100.00)]
        public decimal Price { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Title { get; set; }
    }
}
