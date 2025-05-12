using System.ComponentModel.DataAnnotations;
using Ismile.Models.enums;

namespace Ismile.Models
{
    public class Secretaire
    {
        [Key]
        public long Id { get; set; }

        [Phone]
        public string Telephone { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public Sexe Sexe { get; set; }

        public string Adresse { get; set; } = string.Empty;

        public DateTime DateNaissance { get; set; }

        public string Prenom { get; set; } = string.Empty;

        public string Nom { get; set; } = string.Empty;

        public string Cin { get; set; } = string.Empty;

        public string PhotoDeProfile { get; set; } = string.Empty;

        public DateTime DateDerniereConnexion { get; set; }

        [Required]
        public string MotDePasse { get; set; } = string.Empty;

        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        public DateTime DateDeModification { get; set; }

        public string NomUtilisateur { get; set; } = string.Empty;

        public DateTime DateDeCreation { get; set; }

        public virtual Cabinet CabinetDeTravail { get; set; } = default!;

        public StatusEmploye StatusActuel { get; set; }

        public virtual ICollection<Disponibilite> Disponibilites { get; set; } = new List<Disponibilite>();

        public double SalaireDeBase { get; set; }

        public DateTime DateRetourConge { get; set; }

        public double Prime { get; set; }
    }



}
