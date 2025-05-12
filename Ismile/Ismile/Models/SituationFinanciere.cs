using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Ismile.Models
{
    public class SituationFinanciere
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey(nameof(DossierMedicaleId))]
        public virtual DossierMedicale DossierMedicale { get; set; }
        public long DossierMedicaleId { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }

        public DateTime DateCreation { get; set; }

        public double MontantGlobalRestant { get; set; }

        public double MontantGlobalPaye { get; set; }
    }
}
