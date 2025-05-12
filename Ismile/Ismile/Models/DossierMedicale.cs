using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;
using Microsoft.EntityFrameworkCore;

namespace Ismile.Models
{
    public class DossierMedicale
    {
        [Key]
        public long Id { get; set; }

        public virtual ICollection<RendezVous> Rdvs { get; set; } = new List<RendezVous>();

        public DateTime DateCreation { get; set; } = DateTime.Now;

        public virtual Patient Patient { get; set; } = new Patient();

        public virtual ICollection<Ordonnance> Ordonnances { get; set; } = new List<Ordonnance>();

        public virtual SituationFinanciere SituationFinanciere { get; set; } = new SituationFinanciere();

        public StatutPaiement StatutPaiement { get; set; }

        public long NumeroDossier { get; set; }

        [ForeignKey(nameof(MedecinTraitantId))]
        public virtual Dentiste MedecinTraitant { get; set; } = new Dentiste();

        public long? MedecinTraitantId { get; set; }
    }



}
