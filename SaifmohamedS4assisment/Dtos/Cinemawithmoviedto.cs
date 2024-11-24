using SaifmohamedS4assisment.models;
using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.Dtos
{
    public class Cinemawithmoviedto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int PlaceHolder { get; set; }
        public List<moviewithoutcinmaDto> Movies { get; set; }

    }
}
