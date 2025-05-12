using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;


namespace Ismile.Models
{
    public class HistoriqueMedicale
    {
        [Key]
        public long Id { get; set; }

        public virtual ICollection<Patient> PatientsAvecHistoriqueMedicale { get; set; }

        public string Libelle { get; set; }

        public CategorieHistoriqueMedicale Categorie { get; set; }
    }
}
