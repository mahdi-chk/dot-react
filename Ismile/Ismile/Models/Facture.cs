using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;

namespace Ismile.Models
{
    public class Facture
    {
        [Key]
        public long Id { get; set; }

        public double MontantTotal { get; set; }

        [ForeignKey(nameof(ConsultationId))]
        public virtual Consultation Consultation { get; set; }
        public long ConsultationId { get; set; }

        public TypePaiement TypePaiement { get; set; }

        public double MontantReste { get; set; }

        public virtual SituationFinanciere SituationFinanciere { get; set; }

        public DateTime DateFacture { get; set; }

        public double MontantPaye { get; set; }
    }
}
