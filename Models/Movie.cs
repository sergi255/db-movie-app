using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Title jest wymagane.")]
        [StringLength(50, ErrorMessage = "Pole Tytuł nie może przekraczać 50 znaków.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Pole Description jest wymagane.")]
        [UIHint("LongText")]
        public string Description { get; set; }

        [UIHint("Stars")]
        [Range(1, 5, ErrorMessage = "Ocena filmu musi być liczbą pomiędzy 1 a 5.")]
        [Required(ErrorMessage = "Pole Rating jest wymagane.")]
        public int Rating { get; set; }

        public string? TrailerLink { get; set; }

        public Genre Genre { get; set; }

    }
}
