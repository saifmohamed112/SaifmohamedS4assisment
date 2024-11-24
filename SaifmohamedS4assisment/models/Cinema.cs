using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PlaceHolder {  get; set; }

        public List<Movie> Movies { get; set; }
    }
}
