using SaifmohamedS4assisment.models;
using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.Dtos
{
    public class CinemawithoutMovieDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int PlaceHolder { get; set; }

    }
}
