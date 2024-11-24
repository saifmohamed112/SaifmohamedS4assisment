using SaifmohamedS4assisment.models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.Dtos
{
    public class DirectorDTO
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }

        public List<MovieDTO> Movies { get; set; }
        public NationalityDTO Nationality { get; set; }
    }
}
