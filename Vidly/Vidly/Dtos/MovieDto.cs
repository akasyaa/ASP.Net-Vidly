using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}