using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
   public class PrescriptionDeMedicament
    {
        [Key]
        public long Id { get; set; }

        public int UnitesMinAPrendre { get; set; }

        public int UnitesMaxAPrendre { get; set; }

        public string ContraintesAlimentation { get; set; }

        public string ContraintesTemps { get; set; }

        [ForeignKey(nameof(OrdonnanceId))]
        public virtual Ordonnance Ordonnance { get; set; }
        public long? OrdonnanceId { get; set; }

        [ForeignKey(nameof(MedicamentAPrescrireId))]
        public virtual Medicament Medicament { get; set; }
        public long MedicamentAPrescrireId { get; set; }
    }


}