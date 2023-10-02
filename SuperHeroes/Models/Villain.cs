using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroes.Models
{
    public class Villain
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The villain name is required")]
        public string Name { get; set; }
        public string Background { get; set; }

        [ForeignKey("SuperheroId")]
        public Guid SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}
