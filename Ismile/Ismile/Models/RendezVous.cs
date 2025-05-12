using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;

namespace Ismile.Models
{
    public class RendezVous
    {
        [Key]
        public long Id { get; set; }

        public string Motif { get; set; }

        public TimeSpan Temps { get; set; }

        [ForeignKey(nameof(DossierMedicaleId))]
        public virtual DossierMedicale DossierMedicale { get; set; }
        public long DossierMedicaleId { get; set; }

        [ForeignKey(nameof(ConsultationId))]
        public virtual Consultation Consultation { get; set; }
        public long ConsultationId { get; set; }

        public TypeRDV TypeRDV { get; set; }

        public TimeSpan DateRDV { get; set; }
    }


}
