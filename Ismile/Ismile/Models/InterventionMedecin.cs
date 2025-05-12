using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class InterventionMedecin
    {
        [Key]
        public long Id { get; set; }

        public string NoteMedecin { get; set; }

        [ForeignKey(nameof(ActeId))]
        public virtual Acte Acte { get; set; }
        public long ActeId { get; set; }

        [ForeignKey(nameof(ConsultationId))]
        public virtual Consultation Consultation { get; set; }
        public long ConsultationId { get; set; }

        public long Dent { get; set; }

        public double PrixPatient { get; set; }
    }

}
