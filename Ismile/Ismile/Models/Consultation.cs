using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Ismile.Models.enums;

namespace Ismile.Models
{
    public class Consultation
    {
        [Key]
        public long Id { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }

        public TypeConsultation TypeConsultation { get; set; }

        public virtual Ordonnance Ordonnance { get; set; }

        public DateTime DateConsultation { get; set; }

        [ForeignKey(nameof(DossierMedicaleId))]
        public virtual DossierMedicale DossierMedicale { get; set; }
        public long? DossierMedicaleId { get; set; }

        public virtual ICollection<InterventionMedecin> Interventions { get; set; }
    }



}
