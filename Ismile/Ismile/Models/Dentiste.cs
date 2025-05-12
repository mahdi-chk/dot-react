using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;

namespace Ismile.Models
{
    public class Dentiste
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

        public string PhotoDeProfile { get; set; }

        public DateTime DateDerniereConnexion { get; set; }

        [Required]
        public string MotDePasse { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public DateTime DateDeModification { get; set; }

        public string NomUtilisateur { get; set; }

        public DateTime DateDeCreation { get; set; }

        public virtual Cabinet CabinetDeTravail { get; set; }

        public StatusEmploye StatusActuel { get; set; }

        public virtual ICollection<Disponibilite> Disponibilites { get; set; }

        public double SalaireDeBase { get; set; }

        public DateTime DateRetourConge { get; set; }

        public Specialite Specialite { get; set; }
    }

}
