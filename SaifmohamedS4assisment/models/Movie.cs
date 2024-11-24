using System.ComponentModel.DataAnnotations;

namespace SaifmohamedS4assisment.models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ?Title { get; set; }

        [Required]
        public DateTime publishyear { get; set; }

        public List<Director> ?directors { get; set; }

       public Catigory ?Catigory { get; set; }

        public Cinema ?Cinema { get; set; }


    }
}
