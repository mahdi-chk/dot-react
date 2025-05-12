using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ismile.Models
{
    public class Acte
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        public double PrixDeBase { get; set; }

        public virtual ICollection<InterventionMedecin> Interventions { get; set; }

        [ForeignKey(nameof(CategorieId))]
        public virtual CategorieActe Categorie { get; set; }
        public long CategorieId { get; set; }
    }
}
