using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ismile.Models
{
    public class Medicament
    {
        [Key]
        public long Id { get; set; }

        public string NoteMedecin { get; set; }

        [ForeignKey(nameof(ActeId))]
        public virtual Acte Acte { get; set; }
        public long ActeId { get; set; }

        public virtual ICollection<PrescriptionDeMedicament> Prescriptions { get; set; }
    }

}