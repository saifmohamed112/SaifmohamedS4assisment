using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.models
{
    public class Catigory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
