using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [RequiredAttribute]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Release")]
        public DateTime ReleaseDate { get; set; }



        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage = "Characters are not allowed.")]
        public string Genre { get; set; }

        [Range(1, 500)]
        public decimal Price { get; set; }

        [DisplayName("Pret in RON")]
        public decimal PriceInRON { get; set; }
    }
}