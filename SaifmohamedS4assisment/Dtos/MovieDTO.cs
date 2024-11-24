using SaifmohamedS4assisment.models;
using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.Dtos
{
    public class MovieDTO
    {

        [Required]
        public string? Title { get; set; }

        [Required]
        public DateTime publishyear { get; set; }

        public CatigoryDTO? Catigory { get; set; }

        public CinemawithoutMovieDto Cinema { get; set; }
    }
}
