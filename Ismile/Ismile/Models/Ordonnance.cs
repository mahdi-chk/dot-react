using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class Ordonnance
    {
        [Key]
        public long Id { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(ConsultationId))]
        public virtual Consultation ConsultationConcernee { get; set; }
        public long ConsultationId { get; set; }

        public virtual ICollection<PrescriptionDeMedicament> PrescriptionDeMedicaments { get; set; }
    }

}