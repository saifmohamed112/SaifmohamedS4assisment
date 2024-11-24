using SaifmohamedS4assisment.models;
using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.Dtos
{
    public class moviewithoutcinmaDto
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public DateTime publishyear { get; set; }

        public CatigoryDTO Catigory { get; set; }

    }
}
