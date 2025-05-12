using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class CategorieActe
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Nom { get; set; }

        public string Description { get; set; }
    }
}
