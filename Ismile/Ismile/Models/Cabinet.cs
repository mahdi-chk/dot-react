using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class Cabinet
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Nom { get; set; }

        public string Logo { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public virtual Caisse Caisse { get; set; }

        public virtual ICollection<Dentiste> Dentistes { get; set; }
        public virtual ICollection<Secretaire> Secretaires { get; set; }

        public string Adresse { get; set; }

        [Phone]
        public string Telephone1 { get; set; }

        [Phone]
        public string Telephone2 { get; set; }
        [Phone]

        public string Tel { get; set; }
    }


}
