using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;

namespace Ismile.Models
{

    public class Patient
    {
        [Key]
        public long Id { get; set; }

        [Phone]
        public string Telephone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Sexe Sexe { get; set; }

        public string Adresse { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }

        public string Cin { get; set; }

        public GroupeSanguin GroupeSanguin { get; set; }

        public Mutuelle Mutuelle { get; set; }

        public virtual ICollection<HistoriqueMedicale> HistoriqueMedicale { get; set; }

        public string Profession { get; set; }

        [ForeignKey(nameof(DossierMedicaleId))]
        public virtual DossierMedicale DossierMedicale { get; set; }
        public long DossierMedicaleId { get; set; }
    }


}
