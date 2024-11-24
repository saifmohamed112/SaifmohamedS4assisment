using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaifmohamedS4assisment.models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string ?EmailAddress { get; set; }
        [Required]
        [Phone]
        public string ?Phone { get; set; }

        public List<Movie> ?Movies { get; set; }
        [ForeignKey("NationaltyId")]
        public Nationality? Nationality { get; set; }
        public int NationaltyId { get; set; }

    }
}
