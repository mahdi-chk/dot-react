using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class Caisse
    {
        [Key]
        public long Id { get; set; }

        public double RecetteDuMois { get; set; }
        public double RecetteDeLAnnee { get; set; }
        public double RecetteDuJour { get; set; }

        public virtual ICollection<SituationFinanciere> SituationFinancieres { get; set; }

        [ForeignKey(nameof(CabinetId))]
        public virtual Cabinet Cabinet { get; set; }
        public long CabinetId { get; set; }
    }

}
